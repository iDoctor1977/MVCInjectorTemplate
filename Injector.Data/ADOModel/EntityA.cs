using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class EntityA : IEntityA
    {
        // relazione 1 * M
        public EntityA()
        {
            colEntitiesB = new List<IEntityB>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // collection navigation property
        public virtual ICollection<IEntityB> colEntitiesB { get; set; }
    }
}