namespace Stripe.Infrastructure
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;

    /// <summary>
    /// A Newtonsoft.Json converter for decimal fields that are transmitted as
    /// strings in the Stripe API (the <c>decimal_string</c> format). This
    /// ensures parity with the STJ <c>[JsonNumberHandling(AllowReadingFromString
    /// | WriteAsString)]</c> attribute applied to the same fields.
    /// </summary>
    internal class DecimalStringConverter : JsonConverter<decimal>
    {
        public override decimal ReadJson(JsonReader reader, Type objectType, decimal existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return 0m;
            }

            if (reader.TokenType == JsonToken.String)
            {
                var str = (string)reader.Value;
                return decimal.Parse(str, CultureInfo.InvariantCulture);
            }

            // Also accept bare numbers for flexibility
            return Convert.ToDecimal(reader.Value, CultureInfo.InvariantCulture);
        }

        public override void WriteJson(JsonWriter writer, decimal value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString(CultureInfo.InvariantCulture));
        }
    }
}
