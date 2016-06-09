using Injector.Business.BusinessLayer;
using Injector.Business.BusinessModel;
using Injector.Common.ISupplier;
using Injector.Data.DataSupplier;

namespace Injector.Business
{
    public interface IBusinessStore
    {
        IDataSupplier GetDataSupplier();
        OperatorA GetOperatorA();
        OperatorB GetOperatorB();
        ModelA GetModelA();
        ModelB GetModelB();
    }

    internal class BusinessStore : IBusinessStore
    {
        private static IBusinessStore businessStore;

        public static IBusinessStore InstanceOfBusinessStore
        {
            get { return businessStore; }
            set { businessStore = value; }
        }

        public IDataSupplier GetDataSupplier()
        {
            return new DataSupplier();
        }

        public OperatorA GetOperatorA()
        {
            return new OperatorA();
        }

        public OperatorB GetOperatorB()
        {
            return new OperatorB();
        }

        public ModelA GetModelA()
        {
            return new ModelA();
        }

        public ModelB GetModelB()
        {
            return new ModelB();
        }
    }
}