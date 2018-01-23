using Injector.Common.IVModel;

namespace Injector.Common.ILogic
{
    public interface ILogicA
    {
        bool CreatePost(IVMCreateA vmCreateA);
        IVMDeleteA DeleteGet(IVMDeleteA vmDeleteA);
        bool DeletePost(IVMDeleteA vmDeleteA);
        IVMEditA EditGet(IVMEditA vmEditA);
        bool EditPost(IVMEditA vmEditA);
        IVMDetailsA DetailsGet(IVMDetailsA vmDetailsA);
        IVMListA ListGet(IVMListA vmListA);
    }
}