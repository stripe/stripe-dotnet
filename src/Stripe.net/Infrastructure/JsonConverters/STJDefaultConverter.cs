#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using static Stripe.Infrastructure.SerializablePropertyCache;

    internal class STJDefaultConverter<T> : JsonConverter<T>
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        ///
        /// Adapted from https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/converters-how-to#sample-factory-pattern-converter.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return this.ReadFullObject(ref reader, typeToConvert, options);
        }

        protected T ReadFullObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var allProperties = GetPropertiesForType(typeToConvert);
            var newInstance = Activator.CreateInstance(typeToConvert);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return (T)newInstance;
                }

                // Get the key.
                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }

                string propertyName = reader.GetString();

                foreach (var property in allProperties)
                {
                    if (property.JsonPropertyName == propertyName)
                    {
                        var valueType = property.PropertyInfo.PropertyType;
                        var valueConverter = property.GetConverter(options);

                        // Get the value.
                        reader.Read();
#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
                        object value = valueConverter.Read(ref reader, valueType, options)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

                        property.Set(newInstance, value);
                        break;
                    }
                }
            }

            throw new JsonException();
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
                object valueToSerialize = property.Get(value);

                switch (valueToSerialize)
                {
                    case null:
                        if (property.IgnoreCondition != JsonIgnoreCondition.WhenWritingNull)
                        {
                            writer.WritePropertyName(property.JsonPropertyName);
                            writer.WriteNullValue();
                        }

                        break;
                    default:
                        writer.WritePropertyName(property.JsonPropertyName);

                        var converter = property.GetConverter(options);
                        converter.Write(writer, valueToSerialize, options);

                        break;
                }
            }

            writer.WriteEndObject();
        }
    }
}
#endif
