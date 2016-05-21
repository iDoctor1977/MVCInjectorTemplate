using System;
using Injector.Common.IOperator;

namespace Injector.Business.BusinessLayer
{
    public class InjectorOperator : IInjectorOperator
    {
        public String InjectorToString()
        {
            return "Hello Injection World!";
        }
    }
}