using Injector.Common.ILogic;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Layer
{
    public class LogicA : ABaseLogic, ILogicA
    {
        private static ILogicA LogicAInstance { get; set; }

        #region CONSTRUCTOR

        private LogicA() { }

        private LogicA(ICoreStore coreStore) : base(coreStore) { }

        #endregion

        #region SINGLETON

        public static ILogicA Instance()
        {
            if (LogicAInstance == null)
            {
                LogicAInstance = new LogicA();
            }

            return LogicAInstance;
        }

        public static ILogicA Instance(ICoreStore coreStore)
        {
            if (LogicAInstance == null)
            {
                LogicAInstance = new LogicA(coreStore);
            }

            return LogicAInstance;
        }

        #endregion

        public IVMCreateA CreateGet(IVMCreateA vmCreateA)
        {
            throw new System.NotImplementedException();
        }

        public int CreatePost(IVMCreateA vmCreateA)
        {
            throw new System.NotImplementedException();
        }

        public int DeletePost(IVMDeleteA vmDeleteA)
        {
            throw new System.NotImplementedException();
        }

        public IVMEditA EditGet(IVMEditA vmEditA)
        {
            throw new System.NotImplementedException();
        }

        public int EditPost(IVMEditA vmEditA)
        {
            throw new System.NotImplementedException();
        }

        public IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA)
        {
            throw new System.NotImplementedException();
        }

        public IVMListA ListGet(IVMListA vmListA)
        {
            throw new System.NotImplementedException();
        }
    }
}