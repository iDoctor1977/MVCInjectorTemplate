using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IAConvBase
    {
        IDataStore AConvBaseDataStore { get; set; }
    }
}