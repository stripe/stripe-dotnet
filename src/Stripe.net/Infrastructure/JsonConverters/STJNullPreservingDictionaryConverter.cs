namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Serializes dictionary entries preserving null values. The global
    /// <see cref="JsonIgnoreCondition.WhenWritingNull"/> setting in
    /// <c>JsonEncodedContent</c> would normally skip null dictionary entries, but for
    /// metadata fields on update operations, <c>{"key": null}</c> means "delete this key."
    /// Apply this converter per-property via attribute.
    /// </summary>
    internal class STJNullPreservingDictionaryConverter : JsonConverterFactory
    {
        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.IsGenericType)
            {
                return false;
            }

            return typeToConvert.GetGenericTypeDefinition() == typeof(Dictionary<,>);
        }

        /// <inheritdoc/>
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var keyType = typeToConvert.GenericTypeArguments[0];
            var valueType = typeToConvert.GenericTypeArguments[1];

            var converterType = typeof(InnerConverter<,>).MakeGenericType(keyType, valueType);
            return (JsonConverter)Activator.CreateInstance(converterType);
        }

        private class InnerConverter<TKey, TValue> : JsonConverter<Dictionary<TKey, TValue>>
        {
            public override Dictionary<TKey, TValue> Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                // Standard deserialization handles null values fine.
                // No recursion risk because this converter is per-property (via attribute),
                // not registered globally in the options.
                return JsonSerializer.Deserialize<Dictionary<TKey, TValue>>(ref reader, options);
            }

            public override void Write(
                Utf8JsonWriter writer,
                Dictionary<TKey, TValue> value,
                JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                foreach (var kvp in value)
                {
                    var key = kvp.Key?.ToString();
                    if (key == null)
                    {
                        continue;
                    }

                    writer.WritePropertyName(key);
                    if (kvp.Value == null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        JsonSerializer.Serialize(writer, kvp.Value, options);
                    }
                }

                writer.WriteEndObject();
            }
        }
    }
}
