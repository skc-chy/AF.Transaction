using AF.Transaction.Business;
using AF.Transaction.Common;
using AF.Transaction.Entity.WCFTransactionDemo;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AF.Transaction.Service
{
    public class WCFTransactionDemo : IWCFTransactionDemo
    {
        /// <summary>
        /// Here exception is catched but not killed as it throw FaultException
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns></returns>
        public Result AddEmployee(WCFTransactionEntity employeeData)
        {
            Result result = new Result();
            try
            {
                var buisnessLayer = BLFactory.CreateWCFTransactionEmployeeDemoBL();
                result = buisnessLayer.AddEmployee(employeeData);
            }
            catch (Exception ex)
            {
                throw new FaultException<Result>(result);
            }

            return result;
        }

        /// <summary>
        /// Here exception is catched & killed
        /// The return object contain bool property 'IsValid'
        /// The property set to false in catch; hence transaction would rollback
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns></returns>
        public Result UpdateEmployee(WCFTransactionEntity employeeData)
        {
            Result result = new Result();
            try
            {
                var buisnessLayer = BLFactory.CreateWCFTransactionEmployeeDemoBL();
                result = buisnessLayer.UpdateEmployee(employeeData);
            }
            catch (Exception ex)
            {
                result = new Result { IsValid = false, Message = new List<String> { "Error in update operation" } };
            }

            return result;
        }

        /// <summary>
        /// Exception is not handled
        /// Hence transaction would be rollback, if any exception occur
        /// If there is no exception,then transaction would be commited
        /// </summary>
        /// <param name="empID"></param>
        /// <returns></returns>
        public Result DeleteEmployee(Guid empID)
        {
            var buisnessLayer = BLFactory.CreateWCFTransactionEmployeeDemoBL();
            return buisnessLayer.DeleteEmployee(empID);
        }

        public List<WCFTransactionEntity> GetEmployeeList()
        {
            var buisnessLayer = BLFactory.CreateWCFTransactionEmployeeDemoBL();
            return buisnessLayer.GetEmployeeList();
        }
    }
}
