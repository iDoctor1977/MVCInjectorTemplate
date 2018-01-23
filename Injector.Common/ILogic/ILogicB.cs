using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IVModel;

namespace Injector.Common.ILogic
{
    public interface ILogicB
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