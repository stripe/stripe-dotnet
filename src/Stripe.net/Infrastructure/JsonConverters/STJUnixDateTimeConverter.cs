#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="DateTime"/> or nullable <see cref="DateTime"/> to and from Unix epoch time.
    /// </summary>
    /// <remarks>
    /// This is a somewhat simplified version of the converter with the same name that was added in
    /// Newtonsoft.Json 11.0. Once we bump the minimum version of Newtonsoft.Json to 11.0, we can
    /// start using the provided converter and get rid of this class.
    /// </remarks>
    internal class STJUnixDateTimeConverter : JsonConverter<DateTime?>
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            bool nullable = IsNullable(typeToConvert);
            long seconds;

            if (reader.TokenType == JsonTokenType.Number)
            {
                seconds = reader.GetInt64();
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                if (!long.TryParse(reader.GetString(), out seconds))
                {
                    throw new JsonException(string.Format("Cannot convert invalid value to {0}.", typeToConvert));
                }
            }
            else if (reader.TokenType == JsonTokenType.Null)
            {
                if (!nullable)
                {
                    throw new JsonException(string.Format("Cannot convert null value to {0}.", typeToConvert));
                }

                return null;
            }
            else
            {
                throw new JsonException(string.Format("Unexpected token parsing date. Expected Integer or String, got {0}.", reader.TokenType));
            }

            if (seconds >= 0)
            {
                return DateTimeUtils.UnixEpoch.AddSeconds(seconds);
            }
            else
            {
                throw new JsonException(string.Format("Cannot convert value that is before Unix epoch of 00:00:00 UTC on 1 January 1970 to {0}.", typeToConvert));
            }
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The calling serializer's options.</param>
        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            long seconds = (long)(value.Value.ToUniversalTime() - DateTimeUtils.UnixEpoch).TotalSeconds;

            if (seconds < 0)
            {
                throw new JsonException("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
            }

            writer.WriteNumberValue(seconds);
        }

        private static bool IsNullable(Type t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            if (t.IsValueType)
            {
                return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
            }

            return true;
        }
    }
}
#endif
