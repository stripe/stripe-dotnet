using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stripe.Infrastructure
{
    internal class SourceConverter : JsonConverter
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

            var source = new Source
            {
                Id = incoming.SelectToken("id").ToString()
            };

            if (incoming.SelectToken("object")?.ToString() == "account")
            {
                source.Type = SourceType.Account;
                source.Account = Mapper<StripeAccount>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "bank_account")
            {
                source.Type = SourceType.BankAccount;
                source.BankAccount = Mapper<StripeBankAccount>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "card")
            {
                source.Type = SourceType.Card;
                source.Card = Mapper<StripeCard>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("object")?.ToString() == "source")
            {
                source.Type = SourceType.Source;
                source.SourceObject = Mapper<StripeSource>.MapFromJson(incoming.ToString());
            }

            if (incoming.SelectToken("deleted")?.ToString() == "true")
            {
                source.Type = SourceType.Deleted;
                source.Deleted = Mapper<StripeDeleted>.MapFromJson(incoming.ToString());
            }

            return source;
        }
    }
}