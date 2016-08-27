using AF.Transaction.Business.WCFTransactionDemo;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using SampleApplication.Buisness.DataAccessorDemo;

namespace AF.Transaction.Business
{
    public sealed class BLFactory
    {
        /// <summary>
        /// Unity interception is used for the component AF.Transaction
        /// Unity interception is registered in this method
        /// </summary>
        /// <returns></returns>
        public static ITransactionDemoBL CreateTransactionEmployeeDemoBL()
        {
            var serviceUnity = new UnityContainer();
            serviceUnity.AddNewExtension<Interception>();
            serviceUnity.RegisterType<ITransactionDemoBL, TransactionDemoBL>().Configure<Interception>().SetInterceptorFor<ITransactionDemoBL>(new InterfaceInterceptor());
            return serviceUnity.Resolve<ITransactionDemoBL>();
        }

        public static IWCFTransactionDemoBL CreateWCFTransactionEmployeeDemoBL()
        {
            return new WCFTransactionDemoBL();
        }
    }
}
