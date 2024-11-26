#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class STJEnumerableObjectConverter : JsonConverter<IEnumerable>
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override IEnumerable Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException("STJEnumerableObjectConverter should only be used while serializing.");
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The calling serializer's options.</param>
        public override void Write(Utf8JsonWriter writer, IEnumerable value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            foreach (var property in value.GetType().GetProperties())
            {
                var propertyNameAttribute = property.GetCustomAttribute(typeof(JsonPropertyNameAttribute), false) as JsonPropertyNameAttribute;
                if (propertyNameAttribute == null)
                {
                    // skip any properties not annotated with JsonPropertyName
                    continue;
                }

                var valueToSerialize = property.GetValue(value);

                writer.WritePropertyName(propertyNameAttribute.Name);
                switch (valueToSerialize)
                {
                    case null:
                        // this assumes that all of the members of a Stripe.net IEnumerable can be
                        // written when null, which is a safe assumption at the time this was
                        // written
                        writer.WriteNullValue();
                        break;
                    default:
                        writer.WriteRawValue(JsonSerializer.Serialize(valueToSerialize, options));
                        break;
                }
            }

            writer.WriteEndObject();
        }

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
    }
}
#endif
