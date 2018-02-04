using Injector.Common.IStore;

namespace Injector.Common.IFeature
{
    public interface IABaseFeatureModelA
    {
        ICoreStore ABaseStore { get; set; }
    }
}