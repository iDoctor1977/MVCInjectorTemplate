using Injector.Common.IModel;

namespace Injector.Frontend.Models
{
    public class AViewModel : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}