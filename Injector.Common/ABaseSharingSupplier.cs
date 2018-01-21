using Injector.Common.IABase;
using Injector.Common.IStore;

namespace Injector.Common
{
    public abstract class ABaseSharingSupplier : IABaseSharingSupplier
    {
        private ISharingStore _sharingStore;

        #region CONSTRUCTOR

        internal ABaseSharingSupplier() { }

        internal ABaseSharingSupplier(ISharingStore sharingStore)
        {
            SupplierSharingStore = sharingStore;
        }

        #endregion

        public ISharingStore SupplierSharingStore
        {
            get { return _sharingStore ?? (_sharingStore = SharingStore.Instance()); }
            set { _sharingStore = value; }
        }
    }
}
