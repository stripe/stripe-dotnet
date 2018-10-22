namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class PaymentIntentSourceActionConverter : JsonConverter
    {
        public override bool CanWrite => false;

        protected Dictionary<PaymentIntentSourceActionType, Func<string, IPaymentIntentSourceActionValue>> TypesToMapperFuncs
            => new Dictionary<PaymentIntentSourceActionType, Func<string, IPaymentIntentSourceActionValue>>()
        {
            { PaymentIntentSourceActionType.AuthorizeWithUrl, Mapper<PaymentIntentSourceActionAuthorizeWithUrl>.MapFromJson },
        };

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(PaymentIntentSourceAction);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);

            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var incoming = JObject.Load(reader);
            var sourceAction = new PaymentIntentSourceAction();

            // Parse type
            var typeString = incoming.SelectToken("type")?.ToString();
            PaymentIntentSourceActionType type;
            if (!TryParseEnum<PaymentIntentSourceActionType>(typeString, out type))
            {
                type = PaymentIntentSourceActionType.Unknown;
            }

            sourceAction.Type = type;

            // Parse value according to type
            if (this.TypesToMapperFuncs.ContainsKey(type))
            {
                var mapperFunc = this.TypesToMapperFuncs[type];
                var valueString = incoming.SelectToken("value")?.ToString();
                sourceAction.Value = mapperFunc(valueString);
            }
            else
            {
                sourceAction.Value = null;
            }

            return sourceAction;
        }

        protected static bool TryParseEnum<T>(string str, out T value)
        {
            try
            {
                value = JsonConvert.DeserializeObject<T>($"\"{str}\"");
            }
            catch (JsonSerializationException)
            {
                value = default(T);
                return false;
            }

            return true;
        }
    }
}
