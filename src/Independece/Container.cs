using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independece
{
    public class Container
    {
        private Dictionary<Type, object> RegisteredServices = new Dictionary<Type, object>();

        public void Register<TType, TImp>(TImp Impementation) where TImp : TType
        {
            RegisteredServices.Add(typeof(TType), Impementation);
        }

        public void Register<TType, TImp>(Func<TImp> factory) where TImp : TType
        {
            RegisteredServices.Add(typeof(TType), factory());
        }

        public TImp Resolve<TType, TImp>(TType type)
        {
            return (TImp)RegisteredServices[typeof(TType)];
        }

        public T Resolve<T>() where T : class
        {
            return Activator.CreateInstance<T>();
        }

        public T Resolve<T, TImp>() where T : class
        {
            var constructors = typeof(T).GetConstructors();

            foreach (var constructor in constructors)
            {
                // Put them into a collection ordered by number of params.
            }

            // resolve the constructor with the most amount of params you can resolve.

            return (T)null;
        }
    }
}
