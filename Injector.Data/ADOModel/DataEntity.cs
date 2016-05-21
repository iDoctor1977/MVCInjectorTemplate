using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class DataEntity : IDataEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
