using AF.Transaction.Common;
using AF.Transaction.Entity.WCFTransactionDemo;
using Architecture.Foundation.Transaction;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AF.Transaction.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFTransactionDemo" in both code and config file together.
    [ServiceContract]
    public interface IWCFTransactionDemo
    {
        /// <summary>
        /// Added 'AFTransactionContract' to maintain transaction
        /// If exception occur in this method or any child method, then transaction automatically rollback 
        /// else it will commited; condition exception is not catched & kiled in this method or any child method.
        /// If you want to catch & kill the exception, then return object must have 'IsValid' bool property
        /// if 'IsValid' is false in return object then Transaction automatically rollback
        /// if 'IsValid' is true in return object then Transaction automatically commit
        /// Use Transaction for Insert/Update/Delete operations only
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns>Return type could be anything</returns>
        [AFTransactionContract(TransactionOperationScope.Required)]
        [OperationContract]
        [FaultContract(typeof(Result))]
        Result AddEmployee(WCFTransactionEntity employeeData);

        /// <summary>
        /// Added 'AFTransactionContract' to maintain transaction
        /// If exception occur in this method or any child method, then transaction automatically rollback 
        /// else it will commited; condition exception is not catched & kiled in this method or any child method.
        /// If you want to catch & kill the exception, then return object must have 'IsValid' bool property
        /// if 'IsValid' is false in return object then Transaction automatically rollback
        /// if 'IsValid' is true in return object then Transaction automatically commit
        /// Use Transaction for Insert/Update/Delete operations only
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns>Return type could be anything</returns>
        [AFTransactionContract(TransactionOperationScope.Required)]
        [OperationContract]
        Result UpdateEmployee(WCFTransactionEntity employeeData);

        /// <summary>
        /// Added 'AFTransactionContract' to maintain transaction
        /// If exception occur in this method or any child method, then transaction automatically rollback 
        /// else it will commited; condition exception is not catched & kiled in this method or any child method.
        /// If you want to catch & kill the exception, then return object must have 'IsValid' bool property
        /// if 'IsValid' is false in return object then Transaction automatically rollback
        /// if 'IsValid' is true in return object then Transaction automatically commit
        /// Use Transaction for Insert/Update/Delete operations only
        /// </summary>
        /// <param name="employeeData"></param>
        /// <returns>Return type could be anything</returns>
        [AFTransactionContract(TransactionOperationScope.Required)]
        [OperationContract]
        Result DeleteEmployee(Guid empID);

        [OperationContract]
        List<WCFTransactionEntity> GetEmployeeList();
    }
}
