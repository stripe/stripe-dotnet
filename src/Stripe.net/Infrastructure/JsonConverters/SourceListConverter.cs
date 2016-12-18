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

            var result = new StripeList<Source>
            {
                Data = new List<Source>(),
                HasMore = list.HasMore,
                Object = list.Object,
                TotalCount = list.TotalCount,
                Url = list.Url
            };

            foreach (var item in list.Data)
            {
                var source = new Source();

                if (item.SelectToken("object").ToString() == "bank_account")
                {
                    source.Type = SourceType.BankAccount;
                    source.BankAccount = Mapper<StripeBankAccount>.MapFromJson(item.ToString());
                }

                if (item.SelectToken("object").ToString() == "card")
                {
                    source.Type = SourceType.Card;
                    source.Card = Mapper<StripeCard>.MapFromJson(item.ToString());
                }

                result.Data.Add(source);
            }

            return result;
        }
    }
}