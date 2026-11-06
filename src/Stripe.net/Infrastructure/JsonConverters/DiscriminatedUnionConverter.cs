namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Deserializes a discriminated union by reading the discriminator property
    /// from the JSON payload and dispatching to the matching variant type.
    /// Unknown string discriminators are preserved on instantiable concrete union bases.
    /// </summary>
    public class DiscriminatedUnionConverter : JsonConverter
    {
        private static readonly ConcurrentDictionary<Type, UnionMetadata> MetadataCache = new ConcurrentDictionary<Type, UnionMetadata>();

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException(
                "DiscriminatedUnionConverter should only be used while deserializing. " +
                "Serialization is handled by the concrete variant type's default serializer.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var metadata = GetMetadata(objectType);
            var jsonObject = JObject.Load(reader);

            var discriminatorToken = jsonObject[metadata.DiscriminatorPropertyName];
            if (discriminatorToken == null)
            {
                throw new JsonSerializationException(
                    $"Discriminated union JSON is missing the discriminator property '{metadata.DiscriminatorPropertyName}' " +
                    $"for interface {objectType.Name}.");
            }

            var discriminatorValue = discriminatorToken.Value<string>();
            if (discriminatorValue == null || !metadata.VariantMap.TryGetValue(discriminatorValue, out var variantType))
            {
                if (discriminatorToken.Type != JTokenType.String)
                {
                    throw new JsonSerializationException(
                        $"Unknown discriminator value '{discriminatorValue}' for discriminated union {objectType.Name}. " +
                        $"Known values: {string.Join(", ", metadata.VariantMap.Keys)}.");
                }

                if (objectType.IsInterface || objectType.IsAbstract || objectType.GetConstructor(Type.EmptyTypes) == null)
                {
                    throw new JsonSerializationException(
                        $"Cannot deserialize unknown discriminator value '{discriminatorValue}' for discriminated union {objectType.Name}. " +
                        "Fallback requires a concrete type with a public parameterless constructor.");
                }

                variantType = objectType;
            }

            var instance = Activator.CreateInstance(variantType);
            using (var subReader = jsonObject.CreateReader())
            {
                serializer.Populate(subReader, instance);
            }

            if (instance is StripeEntity entity)
            {
                entity.SetRawJObject(jsonObject);
            }

            return instance;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetCustomAttribute<StripeDiscriminatedUnionAttribute>() != null;
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

        private class UnionMetadata
        {
            public string DiscriminatorPropertyName { get; set; }

            public Dictionary<string, Type> VariantMap { get; set; }
        }
    }
}
