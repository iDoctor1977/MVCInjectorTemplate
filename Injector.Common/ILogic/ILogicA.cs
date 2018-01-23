using Injector.Common.IVModel;

namespace Injector.Common.ILogic
{
    public interface ILogicA
    {
        IVMCreateA CreateGet(IVMCreateA vmCreateA);
        int CreatePost(IVMCreateA vmCreateA);
        int DeletePost(IVMDeleteA vmDeleteA);
        IVMEditA EditGet(IVMEditA vmEditA);
        int EditPost(IVMEditA vmEditA);
        IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA);
        IVMListA ListGet(IVMListA vmListA);
    }
}