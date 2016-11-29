using System;
using System.IO;
using System.Reflection;
using System.Text;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_discount
    {
        private static StripeDiscount _discount;

        static when_mapping_discount()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var json = new StreamReader(
                typeof(when_mapping_discount).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.net.Tests.infrastructure.test_data.discount.json"),
                Encoding.UTF8
            ).ReadToEnd();

            _discount = Mapper<StripeDiscount>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _discount.CustomerId.ShouldEqual("cus_5GC5XeHUC4TmO9");
    }
}