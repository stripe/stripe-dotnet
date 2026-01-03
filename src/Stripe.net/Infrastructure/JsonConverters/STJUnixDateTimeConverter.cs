#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A JsonConverterFactory that handles both DateTime and DateTime? types.
    /// This factory creates specialized converters for each type to properly handle
    /// null values for nullable DateTime properties (fixes issue #3157).
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    internal class STJUnixDateTimeConverter : JsonConverterFactory
#pragma warning restore SA1649 // File name should match first type name
    {
        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(DateTime) || typeToConvert == typeof(DateTime?);
        }

        /// <inheritdoc/>
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert == typeof(DateTime?))
            {
                return new STJUnixNullableDateTimeConverter();
            }

            return new STJUnixDateTimeConverterImpl();
        }
    }

    /// <summary>
    /// Converter for nullable DateTime? that properly handles null JSON values.
    /// </summary>
#pragma warning disable SA1402 // File may only contain a single type
    internal class STJUnixNullableDateTimeConverter : JsonConverter<DateTime?>
#pragma warning restore SA1402 // File may only contain a single type
    {
        private static readonly STJUnixDateTimeConverterImpl BaseConverter = new STJUnixDateTimeConverterImpl();

        /// <inheritdoc/>
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            return BaseConverter.Read(ref reader, typeToConvert, options);
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            BaseConverter.Write(writer, value.Value, options);
        }
    }

    /// <summary>
    /// Converts a <see cref="DateTime"/> to and from Unix epoch time.
    /// </summary>
    /// <remarks>
    /// This is a somewhat simplified version of the converter with the same name that was added in
    /// Newtonsoft.Json 11.0. Once we bump the minimum version of Newtonsoft.Json to 11.0, we can
    /// start using the provided converter and get rid of this class.
    /// </remarks>
#pragma warning disable SA1402 // File may only contain a single type
    internal class STJUnixDateTimeConverterImpl : JsonConverter<DateTime>
#pragma warning restore SA1402 // File may only contain a single type
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
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
            else
            {
                throw new JsonException(string.Format("Unexpected token parsing date. Expected Integer or String, got {0}.", reader.TokenType));
            }

            if (seconds >= 0)
            {
                // As of the 2025-10-29.clover release, there is a bug in the Terminal API
                // where the last_seen_at field is returned as milliseconds rather than seconds.
                // Since we don't know when/how a fix will be put in to change that behavior,
                // we make a heuristic guess to determine if a timestamp is in milliseconds or seconds.
                // This check will work until the year ~5138.
                if (seconds > 5000000000L)
                {
                    return DateTimeUtils.UnixEpoch.AddMilliseconds(seconds);
                }
                else
                {
                    return DateTimeUtils.UnixEpoch.AddSeconds(seconds);
                }
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
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            long seconds = (long)(value.ToUniversalTime() - DateTimeUtils.UnixEpoch).TotalSeconds;

            if (seconds < 0)
            {
                throw new JsonException("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
            }

            writer.WriteNumberValue(seconds);
        }
    }
}
#endif
