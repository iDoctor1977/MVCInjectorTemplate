using System;

namespace Injector.Common.IEntity
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        string DeleteBy { get; set; }
        DateTime? DeleteDate { get; set; }
    }
}