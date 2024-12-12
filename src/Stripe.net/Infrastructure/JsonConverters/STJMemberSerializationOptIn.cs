#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using static Stripe.Infrastructure.SerializablePropertyCache;

    /// <summary>
    /// A JsonConverterFactory to implement the equivalent to
    /// Newtonsoft Json.NET [JsonObject(MemberSerialization.OptIn)].
    /// This is needed to serialize non-public properties such as the
    /// inner ExpandableField properties.
    /// </summary>
    internal class STJMemberSerializationOptIn : JsonConverterFactory
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///     <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass;
        }

        public override JsonConverter CreateConverter(
            Type type,
            JsonSerializerOptions options)
        {
#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJDefaultConverter<>).MakeGenericType(
                    type),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

            return converter;
        }
    }
}
#endif
