using Injector.Business.Feature;
using Injector.Common;
using Injector.Common.IFeature;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Data;

namespace Injector.Business
{
    internal class CoreStore : ICoreStore
    {
        private IDataSupplier _dataSupplier;
        private ISharingSupplier _sharingSupplier;

        private IConcreteAStep1 _concreteAStep1;
        private IConcreteAStep2 _concreteAStep2;
        private IConcreteAStep3 _concreteAStep3;

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

        #region FEATURES

        public IConcreteAStep1 NewConcreteAStep1
        {
            get { return _concreteAStep1 ?? (_concreteAStep1 = new ConcreteAStep1()); }
            set { _concreteAStep1 = value; }
        }

        public IConcreteAStep2 NewConcreteAStep2
        {
            get { return _concreteAStep2 ?? (_concreteAStep2 = new ConcreteAStep2()); }
            set { _concreteAStep2 = value; }
        }

        public IConcreteAStep3 NewConcreteAStep3
        {
            get { return _concreteAStep3 ?? (_concreteAStep3 = new ConcreteAStep3()); }
            set { _concreteAStep3 = value; }
        }

        #endregion
    }
}