using System;

namespace Injector.Common.IEntity
{
    public interface IEntityC : ISoftDelete
    {
        Guid Id { get; set; }
        string Address { get; set; }
        string Cap { get; set; }
    }
}