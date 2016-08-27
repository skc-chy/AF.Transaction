using System;
using System.Collections.Generic;
using AF.Transaction.Common;
using AF.Transaction.Entity.TransactionDemo;

namespace AF.Transaction.Data.TransactionDemo
{

    public interface ITransactionDemoDAL
    {
        Result AddEmployee(TransactionEntity employeeData);

        Result UpdateEmployee(TransactionEntity employeeData);

        Result DeleteEmployee(Guid empID);

        List<TransactionEntity> GetEmployeeList();
    }
}
