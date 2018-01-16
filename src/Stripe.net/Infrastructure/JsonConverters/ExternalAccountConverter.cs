using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stripe.Infrastructure
{
    internal class ExternalAccountConverter : JsonConverter
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
            var incoming = JObject.Load(reader);

            var externalAccount = new StripeExternalAccount
            {
                Id = incoming.SelectToken("id").ToString()
            };

            if (incoming.SelectToken("object")?.ToString() == "bank_account")
            {
                externalAccount.Type = ExternalAccountType.BankAccount;
                externalAccount.BankAccount = Mapper<StripeBankAccount>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "card")
            {
                externalAccount.Type = ExternalAccountType.Card;
                externalAccount.Card = Mapper<StripeCard>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("deleted")?.ToString() == "true")
            {
                externalAccount.Type = ExternalAccountType.Deleted;
                externalAccount.Deleted = Mapper<StripeDeleted>.MapFromJson(incoming.ToString());
            }

            return externalAccount;
        }
    }
}