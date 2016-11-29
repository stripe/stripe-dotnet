using System;
using System.IO;
using System.Reflection;
using System.Text;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_invoice
    {
        private static StripeInvoice _invoice;

        static when_mapping_invoice()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var json = new StreamReader(
                typeof(when_mapping_invoice).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.net.Tests.infrastructure.test_data.invoice.json"),
                Encoding.UTF8
            ).ReadToEnd();

            _invoice = Mapper<StripeInvoice>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
        {
            _invoice.CustomerId.ShouldEqual("cus_5GC5XeHUC4TmO9");
            _invoice.ChargeId.ShouldBeNull();
        };
    }
}