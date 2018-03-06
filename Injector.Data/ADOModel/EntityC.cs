using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class EntityC : IEntityC
    {
        [Key]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Cap { get; set; }
        public bool IsDeleted { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }

        [ForeignKey("extEntitiesA")]
        public Guid IdA { get; set; }

        // collection navigation property
        public virtual IEntityA extEntitiesA { get; set; }

    }
}