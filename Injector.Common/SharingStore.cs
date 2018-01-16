using Injector.Common.DTOModel;
using Injector.Common.IModel;
using Injector.Common.IStore;

namespace Injector.Common
{
    public class SharingStore : ISharingStore
    {
        #region CONSTRUCTOR

        private SharingStore()
        {
        }

        #endregion

        #region SINGLETON

        private static ISharingStore CommonStoreInstance { get; set; }

        public static ISharingStore Instance()
        {
            CommonStoreInstance = new SharingStore();
            return CommonStoreInstance;
        }

        #endregion

        public IModelA NewModelA => new ModelA();
        public IModelB NewModelB => new ModelB();
    }
}
