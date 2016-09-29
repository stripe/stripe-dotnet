using System;
using System.IO;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_card
    {
        private static StripeCard _card;

        static when_mapping_card()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "card.json");
            var json = File.ReadAllText(path);
            _card = Mapper<StripeCard>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _card.CustomerId.ShouldEqual("cus_4KrhtWKRbXk69Y");
    }
}