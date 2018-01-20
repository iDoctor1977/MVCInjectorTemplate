using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Injector.Common.IStore;

namespace Injector.Common
{
    public abstract class ABaseSupplier : IABaseSupplier
    {
        private ISharingStore _sharingStore;

        #region CONSTRUCTOR

        internal ABaseSupplier() { }

        internal ABaseSupplier(ISharingStore sharingStore)
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

    internal interface IABaseSupplier
    {
        ISharingStore SupplierSharingStore { get; set; }
    }
}
