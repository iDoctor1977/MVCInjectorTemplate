using System;
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

        public int CreatePost(IVMCreateA vmCreateA)
        {
            vmCreateA.DTOModelA.Id = ABaseStore.StoreDataSupplier.GetRepositoryA.CreateEntity(vmCreateA.DTOModelA);

            if (vmCreateA.DTOModelA.Id != Guid.Empty)
            {
                return 1;
            }

            return -1;
        }

        public IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA)
        {
            vmDeleteA.DTOModelA = ABaseStore.StoreDataSupplier.GetRepositoryA.ReadEntityById(vmDeleteA.DTOModelA.Id);

            return vmDeleteA;
        }

        public int DeletePost(IVMDeleteA vmDeleteA)
        {
            if (ABaseStore.StoreDataSupplier.GetRepositoryA.DeleteEntity(vmDeleteA.DTOModelA) != -1)
            {
                return 1;
            }

            return -1;
        }

        public IVMEditA EditGet(IVMEditA vmEditA)
        {
            vmEditA.DTOModelA = ABaseStore.StoreDataSupplier.GetRepositoryA.ReadEntityById(vmEditA.DTOModelA.Id);

            return vmEditA;
        }

        public int EditPost(IVMEditA vmEditA)
        {
            if (ABaseStore.StoreDataSupplier.GetRepositoryA.UpdateEntity(vmEditA.DTOModelA) != -1)
            {
                return 1;
            }

            return -1;
        }

        public IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA)
        {
            vmDetailsA.DTOModelA = ABaseStore.StoreDataSupplier.GetRepositoryA.ReadEntityById(vmDetailsA.DTOModelA.Id);

            return vmDetailsA;
        }

        public IVMListA ListGet(IVMListA vmListA)
        {
            vmListA.ListDTOModelA = ABaseStore.StoreDataSupplier.GetRepositoryA.ReadEntities();

            return vmListA;
        }
    }
}