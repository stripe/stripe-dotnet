using System;
using System.IO;
using System.Reflection;
using System.Text;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_subscription
    {
        private static StripeSubscription _subscription;

        static when_mapping_subscription()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var json = new StreamReader(
                typeof(when_mapping_subscription).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.net.Tests.infrastructure.test_data.subscription.json"),
                Encoding.UTF8
            ).ReadToEnd();

            _subscription = Mapper<StripeSubscription>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _subscription.CustomerId.ShouldEqual("cus_5GC5XeHUC4TmO9");
    }
}