namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// System.Text.Json converter factory for discriminated union interfaces.
    /// Reads the discriminator property from the JSON and dispatches to the correct variant type.
    /// </summary>
    internal class STJDiscriminatedUnionConverterFactory : JsonConverterFactory
    {
        private static readonly ConcurrentDictionary<Type, UnionMetadata> MetadataCache = new ConcurrentDictionary<Type, UnionMetadata>();

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.GetTypeInfo().IsInterface &&
                   typeToConvert.GetCustomAttribute<StripeDiscriminatedUnionAttribute>() != null;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var metadata = GetMetadata(typeToConvert);
            var converterType = typeof(STJDiscriminatedUnionConverter<>).MakeGenericType(typeToConvert);
            return (JsonConverter)Activator.CreateInstance(converterType, metadata);
        }

        private static UnionMetadata GetMetadata(Type interfaceType)
        {
            return MetadataCache.GetOrAdd(interfaceType, type =>
            {
                var unionAttr = type.GetCustomAttribute<StripeDiscriminatedUnionAttribute>();
                if (unionAttr == null)
                {
                    throw new InvalidOperationException(
                        $"Type {type.Name} does not have [StripeDiscriminatedUnion] attribute.");
                }

                var variantAttrs = type.GetCustomAttributes<StripeUnionVariantAttribute>();
                var variantMap = new Dictionary<string, Type>();
                foreach (var attr in variantAttrs)
                {
                    variantMap[attr.DiscriminatorValue] = attr.VariantType;
                }

                return new UnionMetadata
                {
                    DiscriminatorPropertyName = unionAttr.DiscriminatorPropertyName,
                    VariantMap = variantMap,
                };
            });
        }

        internal class UnionMetadata
        {
            public string DiscriminatorPropertyName { get; set; }

            public Dictionary<string, Type> VariantMap { get; set; }
        }

        private class STJDiscriminatedUnionConverter<T> : JsonConverter<T>
        {
            private readonly UnionMetadata metadata;

            public STJDiscriminatedUnionConverter(UnionMetadata metadata)
            {
                this.metadata = metadata;
            }

            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return default;
                }

                var jsonElement = JsonElement.ParseValue(ref reader);

                if (!jsonElement.TryGetProperty(this.metadata.DiscriminatorPropertyName, out var discriminatorProp))
                {
                    throw new JsonException(
                        $"Discriminated union JSON is missing the discriminator property '{this.metadata.DiscriminatorPropertyName}' " +
                        $"for interface {typeToConvert.Name}.");
                }

                var discriminatorValue = discriminatorProp.GetString();
                if (discriminatorValue == null || !this.metadata.VariantMap.TryGetValue(discriminatorValue, out var variantType))
                {
                    throw new JsonException(
                        $"Unknown discriminator value '{discriminatorValue}' for discriminated union {typeToConvert.Name}. " +
                        $"Known values: {string.Join(", ", this.metadata.VariantMap.Keys)}.");
                }

                var rawJson = jsonElement.GetRawText();
                return (T)JsonSerializer.Deserialize(rawJson, variantType, options);
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                if (value == null)
                {
                    writer.WriteNullValue();
                    return;
                }

                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
    }
}
