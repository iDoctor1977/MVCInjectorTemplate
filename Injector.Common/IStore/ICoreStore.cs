using Injector.Common.IFeature;
using Injector.Common.ISupplier;

namespace Injector.Common.IStore
{
    public interface ICoreStore
    {
        IDataSupplier StoreDataSupplier { get; set; }
        ISharingSupplier StoreSharingSupplier { get; set; }

        #region FEATURES

        IConcreteAStep1 NewConcreteAStep1 { get; set; }
        IConcreteAStep2 NewConcreteAStep2 { get; set; }
        IConcreteAStep3 NewConcreteAStep3 { get; set; }

        #endregion
    }
}