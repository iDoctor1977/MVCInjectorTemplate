using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseRepository
    {
        IDataStore ABaseStore { get; set; }
    }
}