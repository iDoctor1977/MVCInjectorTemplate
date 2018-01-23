using Injector.Common.IVModel;

namespace Injector.Common.ILogic
{
    public interface ILogicA
    {
        int CreatePost(IVMCreateA vmCreateA);
        IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA);
        int DeletePost(IVMDeleteA vmDeleteA);
        IVMEditA EditGet(IVMEditA vmEditA);
        int EditPost(IVMEditA vmEditA);
        IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA);
        IVMListA ListGet(IVMListA vmListA);
    }
}