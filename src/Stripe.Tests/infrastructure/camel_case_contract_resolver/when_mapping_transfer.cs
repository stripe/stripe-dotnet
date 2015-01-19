using System;
using System.IO;
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
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "transfer.json");
            var json = File.ReadAllText(path);
            _transfer = Mapper<StripeTransfer>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
            _transfer.RecipientId.ShouldEqual("rc_imadethisup");
    }
}