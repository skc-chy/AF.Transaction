using AF.Transaction.Data.TransactionDemo;
using AF.Transaction.Data.WCFTransactionDemo;

namespace AF.Transaction.Data
{
    public sealed class DataFactory
    {
        public static ITransactionDemoDAL CreateTransactionEmployeeDemoDL()
        {
            return new TransactionDemoDAL();
        }

        public static IWCFTransactionDemoDAL CreateWCFTransactionEmployeeDemoDL()
        {
            return new WCFTransactionDemoDAL();
        }
    }
}
