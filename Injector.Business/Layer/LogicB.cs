using System;
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
            vmCreateB.DTOModelB.Id = ABaseStore.StoreDataSupplier.GetRepositoryB.CreateEntity(vmCreateB.DTOModelB);

            if (vmCreateB.DTOModelB.Id != Guid.Empty)
            {
                return 1;
            }

            return -1;
        }

        public IVMDeleteB DeleteGet(IVMDeleteB vmDeleteB)
        {
            vmDeleteB.DTOModelB = ABaseStore.StoreDataSupplier.GetRepositoryA.ReadEntityById(vmDeleteB.DTOModelB.Id);

            return vmDeleteB;

        }

        public int DeletePost(IVMDeleteB vmDeleteB)
        {
            if (ABaseStore.StoreDataSupplier.GetRepositoryB.DeleteEntity(vmDeleteB.DTOModelB) != -1)
            {
                return 1;
            }

            return -1;
        }

        public IVMEditB EditGet(IVMEditB vmEditB)
        {
            vmEditB.DTOModelB = ABaseStore.StoreDataSupplier.GetRepositoryB.ReadEntityById(vmEditB.DTOModelB.Id);

            return vmEditB;
        }

        public int EditPost(IVMEditB vmEditB)
        {
            if (ABaseStore.StoreDataSupplier.GetRepositoryB.UpdateEntity(vmEditB.DTOModelB) != -1)
            {
                return 1;
            }

            return -1;
        }

        public IVMDetailsB DetailsGet(IVMDetailsB vmDetailsB)
        {
            vmDetailsB.DTOModelB = ABaseStore.StoreDataSupplier.GetRepositoryB.ReadEntityById(vmDetailsB.DTOModelB.Id);

            return vmDetailsB;
        }

        public IVMListB ListGet(IVMListB vmListB)
        {
            vmListB.ListDTOModelB = ABaseStore.StoreDataSupplier.GetRepositoryB.ReadEntities();

            return vmListB;
        }
    }
}