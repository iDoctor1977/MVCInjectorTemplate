using System;
using Injector.Common.IFeature;
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

        private LogicA(ICoreBond coreBond) : base(coreBond) { }

        private LogicA(ICoreStore coreStore, ICoreBond coreBond) : base(coreStore, coreBond) { }

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

        public static ILogicA Instance(ICoreBond coreBond)
        {
            if (LogicAInstance == null)
            {
                LogicAInstance = new LogicA(coreBond);
            }

            return LogicAInstance;
        }

        public static ILogicA Instance(ICoreStore coreStore, ICoreBond coreBond)
        {
            if (LogicAInstance == null)
            {
                LogicAInstance = new LogicA(coreStore, coreBond);
            }

            return LogicAInstance;
        }

        #endregion

        public bool CreatePost(IVMCreateA vmCreateA)
        {
            vmCreateA.DTOModelA.Id = ABaseBond.BondDataSupplier.GetRepositoryA.CreateEntity(vmCreateA.DTOModelA);

            if (vmCreateA.DTOModelA.Id != Guid.Empty)
            {
                return true;
            }

            return false;
        }

        public IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA)
        {
            vmDeleteA.DTOModelA = ABaseBond.BondDataSupplier.GetRepositoryA.ReadEntityById(vmDeleteA.DTOModelA.Id);

            return vmDeleteA;
        }

        public bool DeletePost(IVMDeleteA vmDeleteA)
        {
             return ABaseBond.BondDataSupplier.GetRepositoryA.DeleteEntity(vmDeleteA.DTOModelA);
        }

        public IVMEditA EditGet(IVMEditA vmEditA)
        {
            vmEditA.DTOModelA = ABaseBond.BondDataSupplier.GetRepositoryA.ReadEntityById(vmEditA.DTOModelA.Id);

            return vmEditA;
        }

        public bool EditPost(IVMEditA vmEditA)
        {
            return ABaseBond.BondDataSupplier.GetRepositoryA.UpdateEntity(vmEditA.DTOModelA);
        }

        public IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA)
        {
            vmDetailsA.DTOModelA = ABaseBond.BondDataSupplier.GetRepositoryA.ReadEntityById(vmDetailsA.DTOModelA.Id);

            return vmDetailsA;
        }

        public IVMListA ListGet(IVMListA vmListA)
        {
            vmListA.ListDTOModelA = ABaseBond.BondDataSupplier.GetRepositoryA.ReadEntities();

            return vmListA;
        }
    }
}