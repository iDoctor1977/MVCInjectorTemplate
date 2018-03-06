using System;

namespace Injector.Common.IEntity
{
    public interface IEntityA : ISoftDelete
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
}