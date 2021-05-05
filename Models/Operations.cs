using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Interfaces;

namespace DependencyInjectionDemo.Models
{
    public class Operations : IOperationTransient,IOperationScoped,IOperationSingleton,IOperationSingletonInstance
    {
        public Operations() : this(Guid.NewGuid())
        {
        }

        public Operations(Guid id)
        {
            OperationId = id;
        }

        public Guid OperationId { get; private set; }
    }
}
