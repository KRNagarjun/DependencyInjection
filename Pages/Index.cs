using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DependencyInjectionDemo.Interfaces;
using DependencyInjectionDemo.Services;

namespace DependencyInjectionDemo.Pages
{
    public class Index : PageModel
    {
        private readonly IMyDependency _myDependency;

        public Index(
            IMyDependency myDependency,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _myDependency = myDependency;
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            SingletonInstanceOperation = singletonInstanceOperation;
        }

        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get; }
        public IOperationSingletonInstance SingletonInstanceOperation { get; }

        public async Task OnGetAsync()
        {
            await _myDependency.WriteMessage(
                "IndexModel.OnGetAsync created this message.");
        }
    }
}
