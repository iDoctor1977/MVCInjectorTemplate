using Injector.Business;
using Injector.Common;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Common.IVModel;
using Injector.Frontend.Models;

namespace Injector.Frontend
{
    public class WebStore : IWebStore
    {
        private ICoreSupplier _coreSupplier;
        private ISharingSupplier _sharingSupplier;

        #region CONSTRUCTOR

        private WebStore() { }

        private WebStore(ICoreSupplier coreSupplier)
        {
            StoreCoreSupplier = coreSupplier;
        }

        private WebStore(ISharingSupplier sharingSupplier)
        {
            StoreSharingSupplier = sharingSupplier;
        }

        private WebStore(ICoreSupplier coreSupplier, ISharingSupplier sharingSupplier)
        {
            StoreCoreSupplier = coreSupplier;
            StoreSharingSupplier = sharingSupplier;
        }

        #endregion

        #region SINGLETON

        public static IWebStore Instance()
        {
            if (WebStoreInstance == null)
            {
                WebStoreInstance = new WebStore();
            }

            return WebStoreInstance;
        }

        public static IWebStore Instance(ICoreSupplier coreSupplier)
        {
            if (WebStoreInstance == null)
            {
                WebStoreInstance = new WebStore(coreSupplier);
            }

            return WebStoreInstance;
        }
        public static IWebStore Instance(ISharingSupplier sharingSupplier)
        {
            if (WebStoreInstance == null)
            {
                WebStoreInstance = new WebStore(sharingSupplier);
            }

            return WebStoreInstance;
        }
        public static IWebStore Instance(ICoreSupplier coreSupplier, ISharingSupplier sharingSupplier)
        {
            if (WebStoreInstance == null)
            {
                WebStoreInstance = new WebStore(coreSupplier, sharingSupplier);
            }

            return WebStoreInstance;
        }

        #endregion

        private static IWebStore WebStoreInstance { get; set; }

        public ICoreSupplier StoreCoreSupplier
        {
            get { return _coreSupplier ?? (_coreSupplier = CoreSupplier.Instance()); }
            set { _coreSupplier = value; }
        }
        public ISharingSupplier StoreSharingSupplier {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }

        public IVMCreateA NewVMCreateA => new VMCreateA();
        public IVMDeleteA NewVMDeleteA => new VMDeleteA();
        public IVMEditA NewVMEditA => new VMEditA();
        public IVMDetailsA NewVMDetailsA => new VMDetailsA();
        public IVMListA NewVMListA => new VMListA();

        public IVMCreateB NewVMCreateB => new VMCreateB();
        public IVMDeleteB NewVMDeleteB => new VMDeleteB();
        public IVMEditB NewVMEditB => new VMEditB();
        public IVMDetailsB NewVMDetailsB => new VMDetailsB();
        public IVMListB NewVMListB => new VMListB();
    }
}