using Injector.Common.IModel;
using Injector.Common.IStore;
using Injector.Common.ISupplier;

namespace Injector.Common
{
    public class SharingSupplier : ISharingSupplier
    {
        private ISharingStore _sharingStore;

        #region CONSTRUCTOR

        private SharingSupplier()
        {
        }

        public SharingSupplier(ISharingStore commonStore)
        {
            _sharingStore = commonStore;
            if (CommonSupplierInstance == null)
            {
                CommonSupplierInstance = this;
            }
        }

        #endregion

        #region SINGLETON

        private static ISharingSupplier CommonSupplierInstance { get; set; }

        public static ISharingSupplier Instance()
        {
            return CommonSupplierInstance = new SharingSupplier();
        }

        public static ISharingSupplier Instance(ISharingStore commonStore)
        {
            return CommonSupplierInstance = new SharingSupplier(commonStore);
        }

        #endregion

        public ISharingStore SStoreCommonStore
        {
            get { return _sharingStore ?? (_sharingStore = SharingStore.Instance()); }
            set { _sharingStore = value; }
        }

        public IModelA GetModelA()
        {
            return SStoreCommonStore.NewModelA;
        }

        public IModelB GetModelB()
        {
            return SStoreCommonStore.NewModelB;
        }
    }
}
