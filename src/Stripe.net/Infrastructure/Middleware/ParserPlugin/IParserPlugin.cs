namespace Stripe.Infrastructure.Middleware
{
    using System.Reflection;
    using Newtonsoft.Json;

    public interface IParserPlugin
    {
         bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent);
    }
}
