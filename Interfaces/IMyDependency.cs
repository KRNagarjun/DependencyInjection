using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string Message);
    }
}
