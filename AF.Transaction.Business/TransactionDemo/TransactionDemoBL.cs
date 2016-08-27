using System;
using System.Collections.Generic;
using AF.Transaction.Common;
using AF.Transaction.Data;
using AF.Transaction.Entity.TransactionDemo;
using AF.Transaction.Data.TransactionDemo;

namespace SampleApplication.Buisness.DataAccessorDemo
{

    public class TransactionDemoBL : ITransactionDemoBL
    {

        public Result AddEmployee(TransactionEntity employeeData)
        {
            ITransactionDemoDAL data = DataFactory.CreateTransactionEmployeeDemoDL();
            return data.AddEmployee(employeeData);
        }

        public Result UpdateEmployee(TransactionEntity employeeData)
        {
            var data = DataFactory.CreateTransactionEmployeeDemoDL();
            return data.UpdateEmployee(employeeData);
        }

        public Result DeleteEmployee(Guid empID)
        {
            var data = DataFactory.CreateTransactionEmployeeDemoDL();
            return data.DeleteEmployee(empID);
        }

        public List<TransactionEntity> GetEmployeeList()
        {
            var dataAccess = DataFactory.CreateTransactionEmployeeDemoDL();
            return dataAccess.GetEmployeeList();
        }
    }
}
