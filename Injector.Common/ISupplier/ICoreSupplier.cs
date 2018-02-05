using Injector.Common.IFeature;

namespace Injector.Common.ISupplier
{
    public interface ICoreSupplier
    {
        IFeatureA GetFeatureA { get; }
        IFeatureB GetFeatureB { get; }
    }
}