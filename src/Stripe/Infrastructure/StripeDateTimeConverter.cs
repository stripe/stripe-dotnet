using System;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Stripe.Infrastructure
{
    public class StripeDateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(@"""\/Date(" + EpochTime.ConvertDateTimeToEpoch((DateTime)value).ToString() + @")\/""");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) return null;

            if (reader.TokenType == JsonToken.Integer)
                return EpochTime.ConvertEpochToDateTime((long)reader.Value);

            return DateTime.Parse(reader.Value.ToString());
        }
    }
}