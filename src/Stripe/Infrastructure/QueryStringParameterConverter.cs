namespace Stripe.Infrastructure
{
    internal abstract class QueryStringParameterConverter<T>
        : IQueryStringParameterConverter
    {
        string IQueryStringParameterConverter.ConvertToQueryStringValue(object @object)
        {
            return ConvertToQueryStringValue((T) @object);
        }

        public abstract string ConvertToQueryStringValue(T @object);
    }
}