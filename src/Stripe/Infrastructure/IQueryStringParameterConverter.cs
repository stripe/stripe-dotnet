namespace Stripe.Infrastructure
{
    internal interface IQueryStringParameterConverter
    {
        string ConvertToQueryStringValue(object @object);
    }
}