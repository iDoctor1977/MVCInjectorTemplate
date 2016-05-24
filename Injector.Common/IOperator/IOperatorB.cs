using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IOperator
{
    public interface IOperatorB
    {
        IModelB GetModel(int id);
        void AddModel(IModelB model);
        void EditModel(IModelB model);
        void DeleteModel(IModelB model);
        string ToStringOperator();
        IModelB ConvertToModelB(IEntityB entity);
    }
}