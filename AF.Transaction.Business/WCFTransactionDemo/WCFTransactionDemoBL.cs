using System;
using System.Collections.Generic;
using AF.Transaction.Common;
using AF.Transaction.Data;
using AF.Transaction.Entity.WCFTransactionDemo;

namespace AF.Transaction.Business.WCFTransactionDemo
{

    public class WCFTransactionDemoBL : IWCFTransactionDemoBL
    {

        public Result AddEmployee(WCFTransactionEntity employeeData)
        {
            var data = DataFactory.CreateWCFTransactionEmployeeDemoDL();
            return data.AddEmployee(employeeData);
        }

        public Result UpdateEmployee(WCFTransactionEntity employeeData)
        {
            var data = DataFactory.CreateWCFTransactionEmployeeDemoDL();
            return data.UpdateEmployee(employeeData);
        }

        public Result DeleteEmployee(Guid empID)
        {
            var data = DataFactory.CreateWCFTransactionEmployeeDemoDL();
            return data.DeleteEmployee(empID);
        }

        public List<WCFTransactionEntity> GetEmployeeList()
        {
            var dataAccess = DataFactory.CreateWCFTransactionEmployeeDemoDL();
            return dataAccess.GetEmployeeList();
        }
    }
}
