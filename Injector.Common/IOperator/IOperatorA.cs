using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IOperator
{
    public interface IOperatorA
    {
        IModelA GetModel(int id);
        void AddModel(IModelA model);
        void EditModel(IModelA model);
        void DeleteModel(IModelA model);
        string ToStringOperator();
        IModelA ConvertToModelA(IEntityA entity);
    }
}