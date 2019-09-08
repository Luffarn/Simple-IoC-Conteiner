using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Develier.Simple_IoC.Core
{
    public class Container {

        private Dictionary<Type, Func<object>> _enitityMapper = new Dictionary<Type, Func<object>>();

        public Container()
        {

        }

        public void Register<TIn, TOut>()
        {
            _enitityMapper.Add(typeof(TIn), () => GetInstance(typeof(TOut)));
        }

        public T GetInstance<T>()
        {
            return (T) GetInstance(typeof(T));
        }

        private object GetInstance(Type type)
        {
            if (_enitityMapper.ContainsKey(type))
            {
                return _enitityMapper[type]();
            }

            var constructor = type.GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length)
                .First();

            var args = constructor.GetParameters()
                .Select(p => GetInstance(p.ParameterType))
                .ToArray();

            return Activator.CreateInstance(type, args);
        }

    }
}
