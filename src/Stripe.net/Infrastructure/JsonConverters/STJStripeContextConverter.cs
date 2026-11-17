namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// System.Text.Json counterpart of <see cref="StripeContextConverter"/>.
    /// </summary>
    internal class STJStripeContextConverter : JsonConverter<StripeContext>
    {
        public override StripeContext Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.Null:
                    return null;
                case JsonTokenType.String:
                    return (StripeContext)reader.GetString();
                case JsonTokenType.StartObject:
                    return ReadSegmentsObject(ref reader);
                default:
                    throw new JsonException($"Unexpected token {reader.TokenType} when reading StripeContext.");
            }
        }

        public override void Write(Utf8JsonWriter writer, StripeContext value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }

        // Versions without this converter wrote StripeContext as {"Segments": [...]}, and those
        // payloads may still be sitting in a queue or cache.
        // TODO(DEVSDK-3426): remove this fallback in the next major release.
        private static StripeContext ReadSegmentsObject(ref Utf8JsonReader reader)
        {
            List<string> segments = null;
            while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
            {
                var name = reader.GetString();
                if (!string.Equals(name, "Segments", StringComparison.OrdinalIgnoreCase))
                {
                    throw new JsonException($"Unexpected property {name} when reading StripeContext.");
                }

                reader.Read();
                if (reader.TokenType != JsonTokenType.StartArray)
                {
                    throw new JsonException("StripeContext Segments must be an array.");
                }

                segments = new List<string>();
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException("StripeContext Segments must contain only strings.");
                    }

                    segments.Add(reader.GetString());
                }
            }

            if (segments == null)
            {
                throw new JsonException("StripeContext object is missing Segments.");
            }

            return new StripeContext(segments);
        }
    }
}
