using System;
using System.ComponentModel.DataAnnotations;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class EntityB : IEntityB
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
