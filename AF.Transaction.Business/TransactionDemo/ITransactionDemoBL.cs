using System;
using System.Collections.Generic;
using AF.Transaction.Common;
using Architecture.Foundation.Transaction;
using AF.Transaction.Entity.TransactionDemo;

namespace SampleApplication.Buisness.DataAccessorDemo
{
    public interface ITransactionDemoBL
    {
        /// <summary>
        /// Added 'AFTransaction' attribute to maintain transaction
        /// If exception occur in this method or any child method, then transaction automatically rollback 
        /// else it will commited; condition exception is not catched in this method or any child method.
        /// Use Transaction for Insert/Update/Delete operations only
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns>Return type could be anything</returns>
        [AFTransaction(TransactionOperationScope.Required)]
        Result AddEmployee(TransactionEntity employeeData);


        /// <summary>
        /// Added 'AFTransaction' attribute to maintain transaction
        /// If exception occur in this method or any child method, then transaction automatically rollback 
        /// else it will commited; condition exception is not catched in this method or any child method.
        /// Use Transaction for Insert/Update/Delete operations only
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns>Return type could be anything</returns>
        [AFTransaction(TransactionOperationScope.Required)]
        Result UpdateEmployee(TransactionEntity employeeData);


        /// <summary>
        /// Added 'AFTransaction' attribute to maintain transaction
        /// If exception occur in this method or any child method, then transaction automatically rollback 
        /// else it will commited; condition exception is not catched in this method or any child method.
        /// Use Transaction for Insert/Update/Delete operations only
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns>Return type could be anything</returns>
        [AFTransaction(TransactionOperationScope.Required)]
        Result DeleteEmployee(Guid empID);

        List<TransactionEntity> GetEmployeeList();
    }
}
