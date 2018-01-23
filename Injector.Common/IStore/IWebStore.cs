using Injector.Common.ISupplier;
using Injector.Common.IVModel;

namespace Injector.Common.IStore
{
    public interface IWebStore
    {
        ICoreSupplier StoreCoreSupplier { get; set; }
        ISharingSupplier StoreSharingSupplier { get; set; }

        IVMCreateA NewVMCreateA { get; }
        IVMDeleteA NewVMDeleteA { get; }
        IVMEditA NewVMEditA { get; }
        IVMDetailsA NewVMDetailsA { get; }
        IVMListA NewVMListA { get; }

        IVMCreateB NewVMCreateB { get; }
        IVMDeleteB NewVMDeleteB { get; }
        IVMEditB NewVMEditB { get; }
        IVMDetailsB NewVMDetailsB { get; }
        IVMListB NewVMListB { get; }
    }
}