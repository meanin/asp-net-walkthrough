using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BuildingAController.Utils
{
    public class DummyDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            var types = GetType().Assembly.GetTypes()
                .Where(serviceType.IsAssignableFrom)
                .Where(s => !s.IsInterface);
            if (types.Any())
                return Activator.CreateInstance(types.First());

            throw new Exception($"Cannot find parameterless constructor for implementation of {serviceType}");
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}