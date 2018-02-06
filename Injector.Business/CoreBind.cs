using Injector.Common;
using Injector.Common.IBind;
using Injector.Common.ISupplier;
using Injector.Data;

namespace Injector.Business
{
    internal class CoreBind : ICoreBind
    {
        private IDataSupplier _dataSupplier;
        private ISharingSupplier _sharingSupplier;

        #region CONSTRUCTOR

        private CoreBind() { }

        private CoreBind(IDataSupplier dataSupplier)
        {
            BindDataSupplier = dataSupplier;
        }

        private CoreBind(ISharingSupplier sharingSupplier)
        {
            BindSharingSupplier = sharingSupplier;
        }

        private CoreBind(IDataSupplier dataSupplier, ISharingSupplier sharingSupplier)
        {
            BindDataSupplier = dataSupplier;
            BindSharingSupplier = sharingSupplier;
        }

        #endregion

        #region SINGLETON

        private static ICoreBind CoreBindIstance { get; set; }

        public static ICoreBind Instance()
        {
            if (CoreBindIstance == null)
            {
                CoreBindIstance = new CoreBind();
            }

            return CoreBindIstance;
        }

        public static ICoreBind Instance(IDataSupplier dataSupplier)
        {
            if (CoreBindIstance == null)
            {
                CoreBindIstance = new CoreBind(dataSupplier);
            }

            return CoreBindIstance;
        }

        public static ICoreBind Instance(ISharingSupplier sharingSupplier)
        {
            if (CoreBindIstance == null)
            {
                CoreBindIstance = new CoreBind(sharingSupplier);
            }

            return CoreBindIstance;
        }

        public static ICoreBind Instance(IDataSupplier dataSupplier, ISharingSupplier sharingSupplier)
        {
            if (CoreBindIstance == null)
            {
                CoreBindIstance = new CoreBind(dataSupplier, sharingSupplier);
            }

            return CoreBindIstance;
        }

        #endregion

        public IDataSupplier BindDataSupplier
        {
            get { return _dataSupplier ?? (_dataSupplier = DataSupplier.Instance()); }
            set { _dataSupplier = value; }
        }
        public ISharingSupplier BindSharingSupplier
        {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }
    }
}