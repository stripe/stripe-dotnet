namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class PaymentIntentSourceActionConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);

            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var sourceAction = new PaymentIntentSourceAction();

            if (reader.TokenType == JsonToken.Null)
            {
                sourceAction.Type = PaymentIntentSourceActionType.None;
                return sourceAction;
            }

            var incoming = JObject.Load(reader);

            if (incoming.SelectToken("type")?.ToString() == "authorize_with_url")
            {
                sourceAction.Type = PaymentIntentSourceActionType.AuthorizeWithUrl;
                sourceAction.AuthorizeWithUrl = Mapper<PaymentIntentSourceActionAuthorizeWithUrl>.MapFromJson(incoming.SelectToken("value")?.ToString());
            }
            else
            {
                sourceAction.Type = PaymentIntentSourceActionType.Unknown;
            }

            return sourceAction;
        }
    }
}
