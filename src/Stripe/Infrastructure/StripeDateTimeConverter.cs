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
			long seconds;

			if (value is DateTime)
			{
				DateTime dateTime = (DateTime)value;
				DateTime utcDateTime = dateTime.ToUniversalTime();
				seconds = ConvertDateTimeToJavaScriptSeconds(utcDateTime);
			}
#if !PocketPC && !NET20
			else if (value is DateTimeOffset)
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
				DateTimeOffset utcDateTimeOffset = dateTimeOffset.ToUniversalTime();
				seconds = ConvertDateTimeToJavaScriptSeconds(utcDateTimeOffset.UtcDateTime);
			}
#endif
			else
			{
				throw new Exception("Expected date object value.");
			}

			writer.WriteStartConstructor("Date");
			writer.WriteValue(seconds);
			writer.WriteEndConstructor();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			Type t = (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>))
			  ? Nullable.GetUnderlyingType(objectType)
			  : objectType;

			if (reader.TokenType == JsonToken.Null)
			{
				if (!(objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>)))
					throw new Exception(string.Format("Cannot convert null value to {0}.", objectType));

				return null;
			}

			if (reader.TokenType == JsonToken.Integer)
			{
				long seconds = (long)reader.Value;

				if (t == typeof(Nullable<DateTime>))
				{
					return new Nullable<DateTime>(ConvertJavaScriptSecondsToDateTime(seconds));
				}
				else
					return ConvertJavaScriptSecondsToDateTime(seconds);
			}
			else if (reader.TokenType == JsonToken.String)
			{
				if (t == typeof(Nullable<DateTime>))
				{
					return new Nullable<DateTime>(DateTime.Parse(reader.Value.ToString()));
				}
				else
					return DateTime.Parse(reader.Value.ToString());
			}
			else
				throw new Exception(string.Format("Unexpected token parsing date. Expected Integer or String, got {0}.", reader.TokenType));
		}


		private DateTime ConvertJavaScriptSecondsToDateTime(long seconds)
		{
			return new DateTime(1970, 1, 1).AddSeconds(seconds);
		}

		private long ConvertDateTimeToJavaScriptSeconds(DateTime datetime)
		{
			var epochStart = new DateTime(1970, 1, 1);
			if (datetime < epochStart) return 0;
			return Convert.ToInt64(datetime.Subtract(epochStart).TotalSeconds);
		}
		
	}
}
