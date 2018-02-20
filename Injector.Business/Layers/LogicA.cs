using System;
using Injector.Common.IBind;
using Injector.Common.ILogic;
using Injector.Common.IStore;
using Injector.Common.IVModel;

namespace Injector.Business.Layers
{
    public class LogicA : ABaseLogic, ILogicA
    {
        private static ILogicA LogicAInstance { get; set; }

        #region CONSTRUCTOR

        private LogicA() { }

        private LogicA(ICoreStore coreStore) : base(coreStore) { }

        private LogicA(ICoreBind coreBind) : base(coreBind) { }

        private LogicA(ICoreStore coreStore, ICoreBind coreBind) : base(coreStore, coreBind) { }

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

        public static ILogicA Instance(ICoreBind coreBind)
        {
            if (LogicAInstance == null)
            {
                LogicAInstance = new LogicA(coreBind);
            }

            return LogicAInstance;
        }

        public static ILogicA Instance(ICoreStore coreStore, ICoreBind coreBind)
        {
            if (LogicAInstance == null)
            {
                LogicAInstance = new LogicA(coreStore, coreBind);
            }

            return LogicAInstance;
        }

        #endregion

        public bool CreatePost(IVMCreateA vmCreateA)
        {
            vmCreateA.DTOModelA.Id = ABaseBind.BindDataSupplier.GetRepositoryA.CreateEntity(vmCreateA.DTOModelA);

            if (vmCreateA.DTOModelA.Id != Guid.Empty)
            {
                return true;
            }

            return false;
        }

        public IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA)
        {
            vmDeleteA.DTOModelA = ABaseBind.BindDataSupplier.GetRepositoryA.ReadEntityById(vmDeleteA.DTOModelA.Id);

            return vmDeleteA;
        }

        public bool DeletePost(IVMDeleteA vmDeleteA)
        {
             return ABaseBind.BindDataSupplier.GetRepositoryA.DeleteEntity(vmDeleteA.DTOModelA);
        }

        public IVMEditA EditGet(IVMEditA vmEditA)
        {
            vmEditA.DTOModelA = ABaseBind.BindDataSupplier.GetRepositoryA.ReadEntityById(vmEditA.DTOModelA.Id);

            return vmEditA;
        }

        public bool EditPost(IVMEditA vmEditA)
        {
            return ABaseBind.BindDataSupplier.GetRepositoryA.UpdateEntity(vmEditA.DTOModelA);
        }

        public IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA)
        {
            vmDetailsA.DTOModelA = ABaseBind.BindDataSupplier.GetRepositoryA.ReadEntityById(vmDetailsA.DTOModelA.Id);

            return vmDetailsA;
        }

        public IVMListA ListGet(IVMListA vmListA)
        {
            vmListA.ListDTOModelA = ABaseBind.BindDataSupplier.GetRepositoryA.ReadEntities();

            return vmListA;
        }
    }
}