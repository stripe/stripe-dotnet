#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Collections;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using static Stripe.Infrastructure.SerializablePropertyCache;

    /// <summary>
    /// A custom converter for Enumerable objects.  This is needed because
    /// STJ serializes IEnumerable objects as an array, and discards additional
    /// fields (like those in StripeList or StripeSearchResult).
    /// </summary>
    public class STJEnumerableObjectConverter : JsonConverterFactory
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
            return typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override JsonConverter CreateConverter(
            Type type,
            JsonSerializerOptions options)
        {
            Type[] typeArguments = type.GetGenericArguments();
            Type fieldType = typeArguments[0];

#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJEnumerableObjectConverterInner<>).MakeGenericType(
                    type),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

            return converter;
        }

        internal class STJEnumerableObjectConverterInner<T> : JsonConverter<T>
        {
            /// <summary>
            /// Reads the JSON representation of the object.
            /// </summary>
            /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
            /// <param name="typeToConvert">Type of the object.</param>
            /// <param name="options">The calling serializer's options.</param>
            /// <returns>The object value.</returns>
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotSupportedException("STJEnumerableObjectConverter should only be used while serializing.");
            }

            /// <summary>
            /// Writes the JSON representation of the object.
            /// </summary>
            /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
            /// <param name="value">The value.</param>
            /// <param name="options">The calling serializer's options.</param>
            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                var allProperties = GetPropertiesForType(value.GetType());
                writer.WriteStartObject();
                foreach (var property in allProperties)
                {
                    var valueToSerialize = property.Get(value);

                    writer.WritePropertyName(property.JsonPropertyName);
                    switch (valueToSerialize)
                    {
                        case null:
                            // this assumes that all of the members of a Stripe.net IEnumerable can be
                            // written when null, which is a safe assumption at the time this was
                            // written
                            writer.WriteNullValue();
                            break;
                        default:
                            var converter = property.GetConverter(options);
                            converter.Write(writer, valueToSerialize, options);
                            break;
                    }
                }

                writer.WriteEndObject();
            }
        }
    }
}
#endif
