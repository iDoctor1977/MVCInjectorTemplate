using Injector.Business.Layer;
using Injector.Common.DTOModel;
using Injector.Common.ISupplier;
using Injector.Data;

namespace Injector.Business
{
    public interface ICoreStore
    {
        IDataSupplier StoreDataSupplier { get; set; }
        ISharingSupplier StoreSharingSupplier { get; set; }
    }

    internal class CoreStore : ICoreStore
    {
        private IDataSupplier _dataSupplier;
        private ISharingSupplier _sharingSupplier;

        #region CONSTRUCTOR

        private CoreStore() { }

        private CoreStore(IDataSupplier dataSupplier)
        {
            StoreDataSupplier = dataSupplier;
        }

        private CoreStore(ISharingSupplier sharingSupplier)
        {
            StoreSharingSupplier = sharingSupplier;
        }

        private CoreStore(IDataSupplier dataSupplier, ISharingSupplier sharingSupplier)
        {
            StoreDataSupplier = dataSupplier;
            StoreSharingSupplier = sharingSupplier;
        }

        #endregion

        #region SINGLETON

        private static ICoreStore CoreStoreIstance { get; set; }

        public static ICoreStore Instance()
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore();
            }

            return CoreStoreIstance;
        }

        #endregion

        public IDataSupplier StoreDataSupplier { get; set; }
        public ISharingSupplier StoreSharingSupplier { get; set; }
    }
}