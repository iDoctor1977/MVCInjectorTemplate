﻿using Injector.Common.IBind;
using Injector.Common.IStore;

namespace Injector.Common.IABase
{
    public interface IABaseDataSupplier
    {
        IDataBind ABaseBind { get; set; }
        IDataStore ABaseStore { get; set; }
    }
}