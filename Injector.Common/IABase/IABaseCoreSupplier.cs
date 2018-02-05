﻿using Injector.Common.IBond;
using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseCoreSupplier
    {
        ICoreBond ABaseBond { get; set; }
        ICoreStore ABaseStore { get; set; }
    }
}