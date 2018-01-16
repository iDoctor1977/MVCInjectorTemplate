using Injector.Business.Layer;
using Injector.Common.DTOModel;
using Injector.Common.ISupplier;
using Injector.Data;

namespace Injector.Business
{
    public interface IBusinessStore
    {
        IDataSupplier GetDataSupplier();
        LogicalA GetOperatorA();
        LogicalB GetOperatorB();
        ModelA GetModelA();
        ModelB GetModelB();
    }

    internal class CoreStore : IBusinessStore
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

        public LogicalA GetOperatorA()
        {
            return new LogicalA();
        }

        public LogicalB GetOperatorB()
        {
            return new LogicalB();
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