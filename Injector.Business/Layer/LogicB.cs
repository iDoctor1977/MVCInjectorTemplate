using System;
using Injector.Common.IFeature;
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

        private LogicB(ICoreBond coreBond) : base(coreBond) { }

        private LogicB(ICoreStore coreStore, ICoreBond coreBond) : base(coreStore, coreBond) { }

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

        public static ILogicB Instance(ICoreBond coreBond)
        {
            if (LogicBInstance == null)
            {
                LogicBInstance = new LogicB(coreBond);
            }

            return LogicBInstance;
        }

        public static ILogicB Instance(ICoreStore coreStore, ICoreBond coreBond)
        {
            if (LogicBInstance == null)
            {
                LogicBInstance = new LogicB(coreStore, coreBond);
            }

            return LogicBInstance;
        }

        #endregion

        public bool CreatePost(IVMCreateB vmCreateB)
        {
            vmCreateB.DTOModelB.Id = ABaseBond.BondDataSupplier.GetRepositoryB.CreateEntity(vmCreateB.DTOModelB);

            if (vmCreateB.DTOModelB.Id != Guid.Empty)
            {
                return true;
            }

            return false;
        }

        public IVMDeleteB DeleteGet(IVMDeleteB vmDeleteB)
        {
            vmDeleteB.DTOModelB = ABaseBond.BondDataSupplier.GetRepositoryB.ReadEntityById(vmDeleteB.DTOModelB.Id);

            return vmDeleteB;

        }

        public bool DeletePost(IVMDeleteB vmDeleteB)
        {
            return ABaseBond.BondDataSupplier.GetRepositoryB.DeleteEntity(vmDeleteB.DTOModelB);
        }

        public IVMEditB EditGet(IVMEditB vmEditB)
        {
            vmEditB.DTOModelB = ABaseBond.BondDataSupplier.GetRepositoryB.ReadEntityById(vmEditB.DTOModelB.Id);

            return vmEditB;
        }

        public bool EditPost(IVMEditB vmEditB)
        {
            return ABaseBond.BondDataSupplier.GetRepositoryB.UpdateEntity(vmEditB.DTOModelB);
        }

        public IVMDetailsB DetailsGet(IVMDetailsB vmDetailsB)
        {
            vmDetailsB.DTOModelB = ABaseBond.BondDataSupplier.GetRepositoryB.ReadEntityById(vmDetailsB.DTOModelB.Id);

            return vmDetailsB;
        }

        public IVMListB ListGet(IVMListB vmListB)
        {
            vmListB.ListDTOModelB = ABaseBond.BondDataSupplier.GetRepositoryB.ReadEntities();

            return vmListB;
        }
    }
}