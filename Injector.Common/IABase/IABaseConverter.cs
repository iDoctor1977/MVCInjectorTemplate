using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseConverter
    {
        IDataStore ABaseConverterDataStore { get; set; }
    }
}