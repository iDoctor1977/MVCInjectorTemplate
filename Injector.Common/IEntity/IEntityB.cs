using System;

namespace Injector.Common.IEntity
{
    public interface IEntityB
    {
        Guid Id { get; set; }
        string Username { get; set; }
        string Email { get; set; }
    }
}