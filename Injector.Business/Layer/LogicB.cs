using Injector.Common.ILogic;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Layer
{
    public class LogicB : ABaseLogic, ILogicB
    {
        private static ILogicB LogicBInstance { get; set; }

        #region CONSTRUCTOR

        private LogicB() { }

        private LogicB(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        #region SINGLETON

        public static ILogicB Instance()
        {
            if (LogicBInstance == null)
            {
                LogicBInstance = new LogicB();
            }

            return LogicBInstance;
        }

        public static ILogicB Instance(ICoreStore coreStore)
        {
            if (LogicBInstance == null)
            {
                LogicBInstance = new LogicB(coreStore);
            }

            return LogicBInstance;
        }

        #endregion

        public int CreatePost(IVMCreateB vmCreateB)
        {
            throw new System.NotImplementedException();
        }

        public int DeletePost(IVMDeleteB vmDeleteB)
        {
            throw new System.NotImplementedException();
        }

        public IVMEditB EditGet(IVMEditB vmEditB)
        {
            throw new System.NotImplementedException();
        }

        public int EditPost(IVMEditB vmEditB)
        {
            throw new System.NotImplementedException();
        }

        public IVMDetailsB DetailsGet(IVMDetailsB vmDetailsB)
        {
            throw new System.NotImplementedException();
        }

        public IVMListB ListGet(IVMListB vmListB)
        {
            throw new System.NotImplementedException();
        }
    }
}