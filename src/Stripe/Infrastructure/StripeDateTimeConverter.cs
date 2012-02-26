using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;

namespace Stripe.Infrastructure
{
	public class StripeDateTimeConverter : DateTimeConverterBase
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteRawValue(@"""\/Date(" + ConvertDateTimeToEpoch((DateTime)value).ToString() + @")\/""");
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value == null) return null;

			if (reader.TokenType == JsonToken.Integer)
				return ConvertEpochToDateTime((long)reader.Value);

			return DateTime.Parse(reader.Value.ToString());
		}

		private DateTime ConvertEpochToDateTime(long seconds)
		{
			return new DateTime(1970, 1, 1).AddSeconds(seconds);
		}

		private long ConvertDateTimeToEpoch(DateTime datetime)
		{
			var epochStart = new DateTime(1970, 1, 1);
			if (datetime < epochStart) return 0;
			
			return Convert.ToInt64(datetime.Subtract(epochStart).TotalSeconds);
		}
	}
}