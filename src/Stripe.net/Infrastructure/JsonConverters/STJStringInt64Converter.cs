#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a 64-bit integer to and from a string-encoded JSON integer.
    /// </summary>
    internal class STJStringInt64Converter : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (!long.TryParse(reader.GetString(), out long value))
                {
                    throw new JsonException(string.Format("Cannot convert invalid value to {0}.", typeToConvert));
                }

                return value;
            }

            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt64();
            }

            throw new JsonException(string.Format("Unexpected token parsing integer. Expected String or Number, got {0}.", reader.TokenType));
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
#endif
