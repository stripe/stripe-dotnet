namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class ExternalAccountConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IExternalAccount);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);

            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var incoming = JObject.Load(reader);

            var externalAccount = default(IExternalAccount);

            var objectName = incoming.SelectToken("object")?.ToString();

            if (objectName == "bank_account")
            {
                externalAccount = Mapper<BankAccount>.MapFromJson(incoming.ToString());
            }
            else if (objectName == "card")
            {
                externalAccount = Mapper<Card>.MapFromJson(incoming.ToString());
            }

            return externalAccount;
        }
    }
}
