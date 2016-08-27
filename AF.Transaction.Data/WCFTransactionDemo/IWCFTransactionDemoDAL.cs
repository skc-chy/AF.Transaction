using System;
using System.Collections.Generic;
using AF.Transaction.Common;
using AF.Transaction.Entity.WCFTransactionDemo;

namespace AF.Transaction.Data.WCFTransactionDemo
{

    public interface IWCFTransactionDemoDAL
    {
        Result AddEmployee(WCFTransactionEntity employeeData);

        Result UpdateEmployee(WCFTransactionEntity employeeData);

        Result DeleteEmployee(Guid empID);

        List<WCFTransactionEntity> GetEmployeeList();
    }
}
