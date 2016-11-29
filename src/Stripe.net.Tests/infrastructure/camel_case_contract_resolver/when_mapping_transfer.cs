using System;
using System.IO;
using System.Reflection;
using System.Text;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_transfer
    {
        private static StripeTransfer _transfer;

        static when_mapping_transfer()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var json = new StreamReader(
                typeof(when_mapping_transfer).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.net.Tests.infrastructure.test_data.transfer.json"),
                Encoding.UTF8
            ).ReadToEnd();

            _transfer = Mapper<StripeTransfer>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _transfer.RecipientId.ShouldEqual("rc_imadethisup");
    }
}