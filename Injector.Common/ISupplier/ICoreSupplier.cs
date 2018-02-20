using Injector.Common.IFeature;
using Injector.Common.ILogic;

namespace Injector.Common.ISupplier
{
    public interface ICoreSupplier
    {
        IFeatureA GetFeatureA { get; }
        IFeatureB GetFeatureB { get; }

        ILogicA GetLogicA { get; }
    }
}