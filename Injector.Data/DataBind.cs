using Injector.Common;
using Injector.Common.IBind;
using Injector.Common.ISupplier;

namespace Injector.Data
{
    internal class DataBind : IDataBind
    {
        private ISharingSupplier _sharingSupplier;

        #region CONSTRUCTOR

        private DataBind() { }

        private DataBind(ISharingSupplier sharingSupplier)
        {
            BindSharingSupplier = sharingSupplier;
        }

        #endregion

        #region SINGLETON

        private static IDataBind DataBindIstance { get; set; }

        public static IDataBind Instance()
        {
            if (DataBindIstance == null)
            {
                DataBindIstance = new DataBind();
            }

            return DataBindIstance;
        }

        public static IDataBind Instance(ISharingSupplier sharingSupplier)
        {
            if (DataBindIstance == null)
            {
                DataBindIstance = new DataBind(sharingSupplier);
            }

            return DataBindIstance;
        }

        #endregion

        public ISharingSupplier BindSharingSupplier
        {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }
    }
}