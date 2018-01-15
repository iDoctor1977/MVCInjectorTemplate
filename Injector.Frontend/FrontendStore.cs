using Injector.Business;
using Injector.Common.ISupplier;
using Injector.Frontend.Models;

namespace Injector.Frontend
{
    public interface IFrontendStore
    {
        ICoreSupplier GetBusinessSupplier();
        VMCreateA GetCreateViewModelA();
        VMCreateB GetCreateViewModelB();
    }

    internal class FrontendStore : IFrontendStore
    {
        private static IFrontendStore frontendStore;

        public static IFrontendStore InstanceOfFrontendStore
        {
            get { return frontendStore; }
            set { frontendStore = value; }
        }

        public ICoreSupplier GetBusinessSupplier()
        {
            return new BusinessSupplier();
        }

        public VMCreateA GetCreateViewModelA()
        {
            return new VMCreateA();
        }

        public VMCreateB GetCreateViewModelB()
        {
            return new VMCreateB();
        }
    }
}