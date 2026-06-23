namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// STJ converter factory for StripeEntity types. During deserialization,
    /// this converter stores the raw JSON on the entity so that
    /// <see cref="StripeEntity.RawJObject"/> and
    /// <see cref="StripeEntity.RawJsonElement"/> are populated.
    ///
    /// Applied as a type-level <c>[JsonConverter]</c> attribute on every
    /// generated entity class. Users who create custom entities extending
    /// <see cref="StripeEntity"/> can apply this attribute to get the same
    /// serialization behavior.
    /// </summary>
    public class STJStripeEntityConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(StripeEntity).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJStripeEntityConverterInner<>).MakeGenericType(typeToConvert),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null);
            return converter;
        }

        internal class STJStripeEntityConverterInner<T> : STJDefaultConverter<T>
            where T : StripeEntity
        {
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }

                // Consume the reader to extract the raw JSON text.
                // JsonElement.ParseValue is the standard STJ way to read
                // a complete token from a Utf8JsonReader. We only keep
                // the raw text string; the JsonElement (and its backing
                // JsonDocument buffer) is discarded immediately.
                var rawJson = JsonElement.ParseValue(ref reader).GetRawText();

                // Deserialize using the base converter's ReadFullObject
                var newReader = new Utf8JsonReader(Encoding.UTF8.GetBytes(rawJson), new JsonReaderOptions
                {
                    AllowTrailingCommas = options.AllowTrailingCommas,
                    CommentHandling = options.ReadCommentHandling,
                    MaxDepth = options.MaxDepth,
                });
                newReader.Read(); // advance to first token
                T entity = this.ReadFullObject(ref newReader, typeToConvert, options);

                // Store raw JSON string for lazy RawJObject and RawJsonElement
                // properties (both parse on first access).
                entity.SetRawJsonString(rawJson);

                return entity;
            }
        }
    }
}
