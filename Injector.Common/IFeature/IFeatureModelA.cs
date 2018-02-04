using Injector.Common.IVModel;

namespace Injector.Common.IFeature
{
    public interface IFeatureModelA
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