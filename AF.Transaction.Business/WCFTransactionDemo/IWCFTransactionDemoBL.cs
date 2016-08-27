using AF.Transaction.Common;
using AF.Transaction.Entity.WCFTransactionDemo;
using System;
using System.Collections.Generic;

namespace AF.Transaction.Business.WCFTransactionDemo
{
    public interface IWCFTransactionDemoBL
    {
        Result AddEmployee(WCFTransactionEntity employeeData);

        Result UpdateEmployee(WCFTransactionEntity employeeData);

        Result DeleteEmployee(Guid empID);

        List<WCFTransactionEntity> GetEmployeeList();
    }
}
