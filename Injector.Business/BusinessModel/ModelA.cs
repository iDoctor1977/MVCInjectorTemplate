using Injector.Common.IModel;

namespace Injector.Business.BusinessModel
{
    public class ModelA : IModelA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}