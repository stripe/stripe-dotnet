using System;
using System.IO;
using System.Reflection;
using System.Text;
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
            var json = new StreamReader(
                typeof(when_mapping_card).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.net.Tests.infrastructure.test_data.card.json"),
                Encoding.UTF8
            ).ReadToEnd();

            _card = Mapper<StripeCard>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _card.CustomerId.ShouldEqual("cus_4KrhtWKRbXk69Y");
    }
}