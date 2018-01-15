using Injector.Common.IEntity;
using Injector.Common.IModel;

namespace Injector.Common.ILogic
{
    public interface IOperatorA
    {
        void CreateModel(IModelA modelA);
        IModelA ReadModel(int id);
        IModelA ReadModelByName(string name);
        void UpdateModel(IModelA modelA);
        void DeleteModel(IModelA modelA);
        string ToStringOperator();
        IModelA ConvertEntityAToModelA(IEntityA entityA);
        IEntityA ConvertModelAToEntityA(IModelA modelA);
    }
}