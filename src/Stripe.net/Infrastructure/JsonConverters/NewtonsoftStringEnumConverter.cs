namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Newtonsoft converter that serializes any <see cref="StringEnum"/>
    /// subclass as its <see cref="StringEnum.Value"/> string.
    /// </summary>
    internal class NewtonsoftStringEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(StringEnum).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(((StringEnum)value).Value);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException(
                $"Deserialization of {objectType.Name} (StringEnum) is not supported.");
        }
    }
}
