namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// STJ converter factory that serializes any <see cref="StringEnum"/>
    /// subclass as its <see cref="StringEnum.Value"/> string.
    /// </summary>
    internal class STJStringEnumConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(StringEnum).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return (JsonConverter)Activator.CreateInstance(
                typeof(STJStringEnumConverterInner<>).MakeGenericType(typeToConvert));
        }

        private class STJStringEnumConverterInner<T> : JsonConverter<T>
            where T : StringEnum
        {
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotSupportedException(
                    $"Deserialization of {typeToConvert.Name} (StringEnum) is not supported.");
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                if (value == null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    writer.WriteStringValue(value.Value);
                }
            }
        }
    }
}
