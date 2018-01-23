using Injector.Common;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data;

namespace Injector.Business
{
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

        public static ICoreStore Instance(IDataSupplier dataSupplier)
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore(dataSupplier);
            }

            return CoreStoreIstance;
        }

        public static ICoreStore Instance(ISharingSupplier sharingSupplier)
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore(sharingSupplier);
            }

            return CoreStoreIstance;
        }

        public static ICoreStore Instance(IDataSupplier dataSupplier, ISharingSupplier sharingSupplier)
        {
            if (CoreStoreIstance == null)
            {
                CoreStoreIstance = new CoreStore(dataSupplier, sharingSupplier);
            }

            return CoreStoreIstance;
        }

        #endregion

        public IDataSupplier StoreDataSupplier
        {
            get { return _dataSupplier ?? (_dataSupplier = DataSupplier.Instance()); }
            set { _dataSupplier = value; }
        }
        public ISharingSupplier StoreSharingSupplier
        {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }
    }
}