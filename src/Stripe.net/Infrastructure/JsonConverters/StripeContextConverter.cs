namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Serializes a <see cref="StripeContext"/> as its <c>Stripe-Context</c> string, the same shape
    /// the API uses. Without it, the getter-only <see cref="StripeContext.Segments"/> is written but
    /// can't be read back, so a round-trip silently produces an empty context.
    /// </summary>
    internal class StripeContextConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(StripeContext);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(((StripeContext)value).ToString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return null;
                case JsonToken.String:
                    return (StripeContext)(string)reader.Value;
                case JsonToken.StartObject:
                    return ReadSegmentsObject(JObject.Load(reader));
                default:
                    throw new JsonSerializationException(
                        $"Unexpected token {reader.TokenType} when reading StripeContext.");
            }
        }

        // Versions without this converter wrote StripeContext as {"Segments": [...]}, and those
        // payloads may still be sitting in a queue or cache.
        // TODO(DEVSDK-3426): remove this fallback in the next major release.
        private static StripeContext ReadSegmentsObject(JObject obj)
        {
            List<string> segments = null;
            foreach (var property in obj.Properties())
            {
                if (!string.Equals(property.Name, "Segments", StringComparison.OrdinalIgnoreCase))
                {
                    throw new JsonSerializationException(
                        $"Unexpected property {property.Name} when reading StripeContext.");
                }

                if (!(property.Value is JArray array))
                {
                    throw new JsonSerializationException("StripeContext Segments must be an array.");
                }

                segments = new List<string>();
                foreach (var segment in array)
                {
                    if (segment.Type != JTokenType.String)
                    {
                        throw new JsonSerializationException("StripeContext Segments must contain only strings.");
                    }

                    segments.Add((string)segment);
                }
            }

            if (segments == null)
            {
                throw new JsonSerializationException("StripeContext object is missing Segments.");
            }

            return new StripeContext(segments);
        }
    }
}
