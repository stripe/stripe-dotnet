namespace Stripe.Infrastructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
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
            var extensionDataInfo = GetExtensionDataPropertyForType(typeToConvert);
            var newInstance = Activator.CreateInstance(typeToConvert);

            // If there's an extension data property, get or create the dictionary
            IDictionary<string, object> extensionData = null;
            if (extensionDataInfo != null)
            {
                extensionData = extensionDataInfo.Get(newInstance) as IDictionary<string, object>;
                if (extensionData == null)
                {
                    extensionData = new Dictionary<string, object>();
                    extensionDataInfo.Set(newInstance, extensionData);
                }
            }

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

                // Advance the reader to the value token
                reader.Read();

                var property = allProperties.Find(p => p.JsonPropertyName == propertyName);
                if (property != null)
                {
                    var valueType = property.PropertyInfo.PropertyType;

                    // Check for a custom converter attribute on the property
                    if (property.CustomConverterType != null)
                    {
                        var valueConverter = property.GetConverter(options);

                        // Get the value using the custom converter.
#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
                        object value = valueConverter.Read(ref reader, valueType, options)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

                        property.Set(newInstance, value);
                    }
                    else if (property.NumberHandling.HasValue &&
                             (property.NumberHandling.Value & JsonNumberHandling.AllowReadingFromString) != 0 &&
                             reader.TokenType == JsonTokenType.String)
                    {
                        // Property has [JsonNumberHandling(AllowReadingFromString)] and
                        // the wire value is a JSON string — parse the number from the string.
                        var str = reader.GetString();
                        if (str == null)
                        {
                            property.Set(newInstance, null);
                        }
                        else
                        {
                            // Unwrap Nullable<T> to get the underlying type for Convert.ChangeType
                            var targetType = Nullable.GetUnderlyingType(valueType) ?? valueType;
                            property.Set(newInstance, Convert.ChangeType(str, targetType, CultureInfo.InvariantCulture));
                        }
                    }
                    else
                    {
                        object value = JsonSerializer.Deserialize(ref reader, valueType, options);
                        property.Set(newInstance, value);
                    }
                }
                else if (extensionData != null)
                {
                    // Store unknown properties in the extension data dictionary
                    var element = JsonSerializer.Deserialize<JsonElement>(ref reader, options);
                    extensionData[propertyName] = element;
                }
                else
                {
                    // Skip unknown properties to keep the reader aligned
                    reader.Skip();
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
            var type = value.GetType();
            var allProperties = GetPropertiesForType(type);
            var extensionDataInfo = GetExtensionDataPropertyForType(type);

            writer.WriteStartObject();
            foreach (var property in allProperties)
            {
                object valueToSerialize = property.Get(value);

                switch (valueToSerialize)
                {
                    case null:
                        // If this is an emptyable property that was explicitly set to null,
                        // write null even if the global ignore condition would skip it.
                        bool forceWriteNull = value is IHasSetTracking tracked
                            && tracked.IsPropertySet(property.PropertyInfo.Name);

                        // Use property-level ignore condition if set, otherwise use global setting
                        var effectiveIgnoreCondition = property.IgnoreCondition ?? options.DefaultIgnoreCondition;

                        if (forceWriteNull ||
                            (effectiveIgnoreCondition != JsonIgnoreCondition.WhenWritingNull &&
                            effectiveIgnoreCondition != JsonIgnoreCondition.Always))
                        {
                            writer.WritePropertyName(property.JsonPropertyName);
                            writer.WriteNullValue();
                        }

                        break;
                    default:
                        writer.WritePropertyName(property.JsonPropertyName);

                        if (property.NumberHandling.HasValue &&
                            (property.NumberHandling.Value & JsonNumberHandling.WriteAsString) != 0 &&
                            valueToSerialize is IConvertible)
                        {
                            writer.WriteStringValue(Convert.ToString(valueToSerialize, CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            var converter = property.GetConverter(options);
                            converter.Write(writer, valueToSerialize, options);
                        }

                        break;
                }
            }

            // Write extension data entries (e.g. ExtraParams) as top-level properties
            if (extensionDataInfo != null)
            {
                if (extensionDataInfo.Get(value) is IDictionary extData)
                {
                    foreach (DictionaryEntry entry in extData)
                    {
                        var key = entry.Key?.ToString();
                        if (key == null)
                        {
                            continue;
                        }

                        writer.WritePropertyName(key);
                        JsonSerializer.Serialize(writer, entry.Value, options);
                    }
                }
            }

            writer.WriteEndObject();
        }
    }
}
