using Injector.Common.IVModel;

namespace Injector.Common.IFeature
{
    public interface IFeatureB
    {
        bool CreatePost(IVMCreateB vmCreateB);
        IVMDeleteB DeleteGet(IVMDeleteB vmDeleteB);
        bool DeletePost(IVMDeleteB vmDeleteB);
        IVMEditB EditGet(IVMEditB vmEditB);
        bool EditPost(IVMEditB vmEditB);
        IVMDetailsB DetailsGet(IVMDetailsB vmDetailsB);
        IVMListB ListGet(IVMListB vmListB);
    }
}