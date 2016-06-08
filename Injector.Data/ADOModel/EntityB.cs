using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    [Table("EntitiesB")]
    public class EntityB : IEntityB
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public virtual IEntityA extEntitiesA { get; set; }
    }
}
