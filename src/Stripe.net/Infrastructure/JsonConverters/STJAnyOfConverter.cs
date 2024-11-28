#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="IAnyOf"/> to and from JSON.
    /// </summary>
    public class STJAnyOfConverter : JsonConverter<object>
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            TestProfiler.Enter("STJAnyOfConverter");
            object o = null;

            // Try to deserialize with each possible type
            var elem = JsonElement.ParseValue(ref reader);
            foreach (var type in typeToConvert.GenericTypeArguments)
            {
                try
                {
                    o = JsonSerializer.Deserialize(elem.GetRawText(), type, options);

                    // If deserialization succeeds, stop
                    break;
                }
                catch (JsonException)
                {
                    // Do nothing, just try the next type
                }
            }

            if (o == null)
            {
                throw new JsonException(string.Format(
                    "Cannot deserialize the current JSON object into any of the expected types ({0}).",
                    string.Join(", ", typeToConvert.GenericTypeArguments.Select(t => t.FullName))));
            }

            TestProfiler.Exit("STJAnyOfConverter");
            return Activator.CreateInstance(typeToConvert, o);
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The calling serializer's options.</param>
        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    JsonSerializer.Serialize(writer, null, options);
                    break;

                case IAnyOf anyOf:
                    JsonSerializer.Serialize(writer, anyOf.Value, options);
                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected value when converting AnyOf. Expected IAnyOf, got {0}.",
                        value.GetType()));
            }
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
            return typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
#endif
