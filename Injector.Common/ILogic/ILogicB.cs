using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IVModel;

namespace Injector.Common.ILogic
{
    public interface ILogicB
    {
        int CreatePost(IVMCreateB vmCreateB);
        int DeletePost(IVMDeleteB vmDeleteB);
        IVMEditB EditGet(IVMEditB vmEditB);
        int EditPost(IVMEditB vmEditB);
        IVMDetailsB DetailsGet(IVMDetailsB vmDetailsB);
        IVMListB ListGet(IVMListB vmListB);
    }
}