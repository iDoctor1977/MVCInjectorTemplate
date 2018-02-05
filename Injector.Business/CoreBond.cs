using Injector.Common;
using Injector.Common.IBond;
using Injector.Common.ISupplier;
using Injector.Data;

namespace Injector.Business
{
    internal class CoreBond : ICoreBond
    {
        private IDataSupplier _dataSupplier;
        private ISharingSupplier _sharingSupplier;

        #region CONSTRUCTOR

        private CoreBond() { }

        private CoreBond(IDataSupplier dataSupplier)
        {
            BondDataSupplier = dataSupplier;
        }

        private CoreBond(ISharingSupplier sharingSupplier)
        {
            BondSharingSupplier = sharingSupplier;
        }

        private CoreBond(IDataSupplier dataSupplier, ISharingSupplier sharingSupplier)
        {
            BondDataSupplier = dataSupplier;
            BondSharingSupplier = sharingSupplier;
        }

        #endregion

        #region SINGLETON

        private static ICoreBond CoreBondIstance { get; set; }

        public static ICoreBond Instance()
        {
            if (CoreBondIstance == null)
            {
                CoreBondIstance = new CoreBond();
            }

            return CoreBondIstance;
        }

        public static ICoreBond Instance(IDataSupplier dataSupplier)
        {
            if (CoreBondIstance == null)
            {
                CoreBondIstance = new CoreBond(dataSupplier);
            }

            return CoreBondIstance;
        }

        public static ICoreBond Instance(ISharingSupplier sharingSupplier)
        {
            if (CoreBondIstance == null)
            {
                CoreBondIstance = new CoreBond(sharingSupplier);
            }

            return CoreBondIstance;
        }

        public static ICoreBond Instance(IDataSupplier dataSupplier, ISharingSupplier sharingSupplier)
        {
            if (CoreBondIstance == null)
            {
                CoreBondIstance = new CoreBond(dataSupplier, sharingSupplier);
            }

            return CoreBondIstance;
        }

        #endregion

        public IDataSupplier BondDataSupplier
        {
            get { return _dataSupplier ?? (_dataSupplier = DataSupplier.Instance()); }
            set { _dataSupplier = value; }
        }
        public ISharingSupplier BondSharingSupplier
        {
            get { return _sharingSupplier ?? (_sharingSupplier = SharingSupplier.Instance()); }
            set { _sharingSupplier = value; }
        }
    }
}