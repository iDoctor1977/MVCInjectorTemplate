using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class EntityB : IEntityB
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
