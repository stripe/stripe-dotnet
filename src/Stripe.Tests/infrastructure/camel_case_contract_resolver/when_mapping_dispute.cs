using System;
using System.IO;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_dispute
    {
        private static StripeDispute _dispute;

        static when_mapping_dispute()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "dispute.json");
            var json = File.ReadAllText(path);
            _dispute = Mapper<StripeDispute>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _dispute.ChargeId.ShouldEqual("ch_14aX6m2eZvKYlo2C1awwC61Y");
    }
}