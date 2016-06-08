using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    [Table("EntitesA")]
    public class EntityA : IEntityA
    {
        // relazione 1 * M
        public EntityA()
        {
            colEntitiesB = new List<IEntityB>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // collection navigation property
        public virtual ICollection<IEntityB> colEntitiesB { get; set; }
    }
}