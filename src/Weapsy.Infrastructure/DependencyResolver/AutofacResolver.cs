﻿using System.Collections.Generic;
using Autofac;
using System.Linq;

namespace Weapsy.Infrastructure.DependencyResolver
{
    public class AutofacResolver : IResolver
    {
        private readonly IComponentContext _context;

        public AutofacResolver(IComponentContext context)
        {
            _context = context;
        }

        public T Resolve<T>()
        {
            return _context.Resolve<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _context.Resolve<IEnumerable<T>>().ToList();
        }
    }
}
