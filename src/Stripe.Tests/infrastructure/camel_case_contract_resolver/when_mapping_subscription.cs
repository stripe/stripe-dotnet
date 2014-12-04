using System;
using System.IO;
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
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "subscription.json");
            var json = File.ReadAllText(path);
            _subscription = Mapper<StripeSubscription>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _subscription.CustomerId.ShouldEqual("cus_5GC5XeHUC4TmO9");
    }
}