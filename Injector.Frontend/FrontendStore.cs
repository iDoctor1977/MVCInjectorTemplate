using Injector.Business.BusinessSupplier;
using Injector.Common.ISupplier;
using Injector.Frontend.Models.ViewModelsA;
using Injector.Frontend.Models.ViewModelsB;

namespace Injector.Frontend
{
    public interface IFrontendStore
    {
        IBusinessSupplier GetBusinessSupplier();
        CreateViewModelA GetCreateViewModelA();
        CreateViewModelB GetCreateViewModelB();
    }

    internal class FrontendStore : IFrontendStore
    {
        private static IFrontendStore frontendStore;

        public static IFrontendStore InstanceOfFrontendStore
        {
            get { return frontendStore; }
            set { frontendStore = value; }
        }

        public IBusinessSupplier GetBusinessSupplier()
        {
            return new BusinessSupplier();
        }

        public CreateViewModelA GetCreateViewModelA()
        {
            return new CreateViewModelA();
        }

        public CreateViewModelB GetCreateViewModelB()
        {
            return new CreateViewModelB();
        }
    }
}