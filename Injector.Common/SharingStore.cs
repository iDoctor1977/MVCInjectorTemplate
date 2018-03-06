using Injector.Common.DTOModel;
using Injector.Common.IEntity;
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

        private static ISharingStore SharingStoreInstance { get; set; }

        public static ISharingStore Instance()
        {
            if (SharingStoreInstance == null)
            {
                SharingStoreInstance = new SharingStore();
            }

            return SharingStoreInstance;
        }

        #endregion

        public IEntityA NewModelA => new ModelA();
        public IEntityB NewModelB => new ModelB();
    }
}
