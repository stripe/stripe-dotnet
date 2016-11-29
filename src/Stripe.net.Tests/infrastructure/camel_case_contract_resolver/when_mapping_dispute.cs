using System;
using System.IO;
using System.Reflection;
using System.Text;
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
            var json = new StreamReader(
                typeof(when_mapping_dispute).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.net.Tests.infrastructure.test_data.dispute.json"),
                Encoding.UTF8
            ).ReadToEnd();

            _dispute = Mapper<StripeDispute>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _dispute.ChargeId.ShouldEqual("ch_14aX6m2eZvKYlo2C1awwC61Y");
    }
}