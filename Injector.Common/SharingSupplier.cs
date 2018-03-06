using Injector.Common.IEntity;
using Injector.Common.IStore;
using Injector.Common.ISupplier;

namespace Injector.Common
{
    public class SharingSupplier : ABaseSharingSupplier, ISharingSupplier
    {
        #region CONSTRUCTOR

        private SharingSupplier() { }

        private SharingSupplier(ISharingStore sharingStore) : base(sharingStore) { }

        #endregion

        #region SINGLETON

        private static ISharingSupplier SharingSupplierInstance { get; set; }

        public static ISharingSupplier Instance()
        {
            if (SharingSupplierInstance == null)
            {
                SharingSupplierInstance = new SharingSupplier();
            }

            return SharingSupplierInstance;
        }

        public static ISharingSupplier Instance(ISharingStore sharingStore)
        {
            if (SharingSupplierInstance == null)
            {
                SharingSupplierInstance = new SharingSupplier(sharingStore);
            }

            return SharingSupplierInstance;
        }

        #endregion

        public IEntityA GetModelA()
        {
            return SupplierSharingStore.NewModelA;
        }

        public IEntityB GetModelB()
        {
            return SupplierSharingStore.NewModelB;
        }
    }
}
