using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.IOperator
{
    public interface IOperatorB
    {
        void CreateModel(IModelB modelB);
        IModelB ReadModel(int id);
        IModelB ReadModelByUsername(string username);
        void UpdateModel(IModelB modelB);
        void DeleteModel(IModelB modelB);
        string ToStringOperator();
        IModelB ConvertEntityBToModelB(IEntityB entityB);
        IEntityB ConvertModelBToEntityB(IModelB modelB);
    }
}