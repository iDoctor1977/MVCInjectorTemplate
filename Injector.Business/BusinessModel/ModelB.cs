using Injector.Common.IModel;

namespace Injector.Business.BusinessModel
{
    public class ModelB : IModelB
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}