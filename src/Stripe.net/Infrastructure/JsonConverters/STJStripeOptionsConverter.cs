namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// STJ converter factory for Stripe options types (request parameter
    /// classes). Implements opt-in member serialization — only properties
    /// annotated with <c>[JsonPropertyName]</c> are included.
    ///
    /// Applied as a type-level <c>[JsonConverter]</c> attribute on every
    /// generated options class. Users who create custom options classes
    /// implementing <see cref="INestedOptions"/> can apply this attribute
    /// to get the same serialization behavior.
    /// </summary>
    public class STJStripeOptionsConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(INestedOptions).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJDefaultConverter<>).MakeGenericType(typeToConvert),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null);
            return converter;
        }
    }
}
