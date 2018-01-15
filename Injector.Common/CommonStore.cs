using Injector.Common.DTOModel;
using Injector.Common.IModel;
using Injector.Common.IStore;

namespace Injector.Common
{
    public class CommonStore : ICommonStore
    {
        #region CONSTRUCTOR

        private CommonStore()
        {
        }

        #endregion

        #region SINGLETON

        private static ICommonStore CommonStoreInstance { get; set; }

        public static ICommonStore Instance()
        {
            CommonStoreInstance = new CommonStore();
            return CommonStoreInstance;
        }

        #endregion

        public IModelA NewModelA => new ModelA();
        public IModelB NewModelB => new ModelB();
    }
}
