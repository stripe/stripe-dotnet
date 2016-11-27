using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stripe.Infrastructure
{
    internal class SourceListConverter : JsonConverter
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
            var list = JObject.Load(reader).ToObject<StripeList<dynamic>>();

            var result = new StripeList<Source> {Data = new List<Source>()};

            foreach (var item in list.Data)
            {
                result.Data.Add(item.SelectToken("object").ToString() == "bank_account"
                                    ? new Source() {BankAccount = item.ToObject<StripeBankAccount>(), Type = SourceType.BankAccount}
                                    : new Source() {Card = item.ToObject<StripeCard>(), Type = SourceType.Card});
            }

            return result;
        }
    }
}