using System;

namespace Stripe.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    internal class QueryStringParameterConverterAttribute : Attribute
    {
        private readonly Type _converterType;

        public QueryStringParameterConverterAttribute(string typename)
            : this(Type.GetType(typename))
        {
        }

        public QueryStringParameterConverterAttribute(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (!typeof (IQueryStringParameterConverter).IsAssignableFrom(type))
            {
                throw new ArgumentException("Type must derive from IQueryStringParameterConverter");
            }

            _converterType = type;
        }

        public IQueryStringParameterConverter GetConverter()
        {
            return (IQueryStringParameterConverter)Activator.CreateInstance(_converterType);
        }
    }
}