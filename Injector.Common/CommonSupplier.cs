using Injector.Common.IModel;
using Injector.Common.IStore;
using Injector.Common.ISupplier;

namespace Injector.Common
{
    public class CommonSupplier : ICommonSupplier
    {
        private ICommonStore _commonStore;

        #region CONSTRUCTOR

        private CommonSupplier()
        {
        }

        public CommonSupplier(ICommonStore commonStore)
        {
            _commonStore = commonStore;
            if (CommonSupplierInstance == null)
            {
                CommonSupplierInstance = this;
            }
        }

        #endregion

        #region SINGLETON

        private static ICommonSupplier CommonSupplierInstance { get; set; }

        public static ICommonSupplier Instance()
        {
            return CommonSupplierInstance = new CommonSupplier();
        }

        public static ICommonSupplier Instance(ICommonStore commonStore)
        {
            return CommonSupplierInstance = new CommonSupplier(commonStore);
        }

        #endregion

        public ICommonStore CSCommonStore
        {
            get { return _commonStore ?? (_commonStore = CommonStore.Instance()); }
            set { _commonStore = value; }
        }

        public IModelA GetModelA()
        {
            return CSCommonStore.NewModelA;
        }

        public IModelB GetModelB()
        {
            return CSCommonStore.NewModelB;
        }
    }
}
