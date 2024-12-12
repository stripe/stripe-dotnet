#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using static Stripe.Infrastructure.SerializablePropertyCache;

    /// <summary>
    /// This converter can be used to deserialize any Stripe object. It is mainly useful for
    /// polymorphic attributes, when the property's type is an interface instead of a concrete type.
    /// In this case, the converter will use the value of the `object` key in the JSON payload to
    /// decide which concrete type to instantiate. If no concrete type is found (or if one is found,
    /// but it's not compatible with the expected interface), then the converter returns `null`.
    /// </summary>
    ///
    internal class STJStripeObjectConverter : JsonConverterFactory
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
            var typeInfo = objectType.GetTypeInfo();
            return (typeInfo.IsInterface && typeInfo.FullName.StartsWith("Stripe")) ||
                    typeInfo.FullName.Equals("Stripe.V2.Event");
        }

        public override JsonConverter CreateConverter(
            Type type,
            JsonSerializerOptions options)
        {
#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJStripeObjectConverterInner<>).MakeGenericType(
                    type),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

            return converter;
        }

        internal class STJStripeObjectConverterInner<T> : STJDefaultConverter<T>
        where T : class
        {
            /// <summary>
            /// Reads the JSON representation of the object.  This creates the appropriate
            /// type by examining the object property in the JSON (instead of looking at the
            /// typeToConvert).
            /// </summary>
            /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
            /// <param name="typeToConvert">Type of the object.</param>
            /// <param name="options">The calling serializer's options.</param>
            /// <returns>The object value.</returns>
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }

                var jsonObject = JsonElement.ParseValue(ref reader);
                var objectValue = jsonObject.GetProperty("object").GetString();

                Type concreteType = StripeTypeRegistry.GetConcreteType(typeToConvert, objectValue);
                if (concreteType == null)
                {
                    // Couldn't find a concrete type to instantiate, return null.
                    return null;
                }

                return (T)JsonSerializer.Deserialize(jsonObject, concreteType, options);
            }
        }
    }
}
#endif
