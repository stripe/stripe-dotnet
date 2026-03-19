namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// A Newtonsoft.Json converter for long fields that are transmitted as
    /// strings in the Stripe API (the <c>int64_string</c> format). This
    /// ensures parity with the STJ <c>[JsonNumberHandling(AllowReadingFromString
    /// | WriteAsString)]</c> attribute applied to the same fields.
    /// </summary>
    internal class Int64StringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(long) || objectType == typeof(long?);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool nullable = IsNullable(objectType);
            if (reader.TokenType == JsonToken.Null)
            {
                if (!nullable)
                {
                    throw new JsonSerializationException(string.Format("Cannot convert null value to {0}.", objectType));
                }

                return null;
            }

            long value;
            if (reader.TokenType == JsonToken.String)
            {
                if (!long.TryParse((string)reader.Value!, out value))
                {
                    throw new JsonSerializationException(string.Format("Cannot convert invalid value to {0}.", objectType));
                }
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                value = (long)reader.Value!;
            }
            else
            {
                throw new JsonSerializationException(string.Format("Unexpected token parsing integer. Expected String or Integer, got {0}.", reader.TokenType));
            }

            return value;
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
