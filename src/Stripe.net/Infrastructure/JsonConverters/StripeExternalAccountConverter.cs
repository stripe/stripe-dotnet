using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stripe.Infrastructure
{
    internal class StripeExternalAccountConverter : JsonConverter
    {
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

            var source = new StripeExternalAccount
            {
                Id = incoming.SelectToken("id").ToString()
            };

            if (incoming.SelectToken("object").ToString() == "bank_account")
            {
                source.Type = StripeExternalAccountType.BankAccount;
                source.BankAccount = Mapper<StripeBankAccount>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object").ToString() == "card")
            {
                source.Type = StripeExternalAccountType.Card;
                source.Card = Mapper<StripeCard>.MapFromJson(incoming.ToString());
            }

            return source;
        }
    }
}