using System;
using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class EntityC : IEntityC
    {
        [Key]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Cap { get; set; }

        // collection navigation property
        public virtual IEntityA extEntitiesA { get; set; }
    }
}