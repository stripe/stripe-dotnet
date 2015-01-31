using System;
using System.IO;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_invoice_item
    {
        private static StripeInvoiceLineItem _invoice;

        static when_mapping_invoice_item()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "invoice_item.json");
            var json = File.ReadAllText(path);
            _invoice = Mapper<StripeInvoiceLineItem>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
        {
            _invoice.CustomerId.ShouldEqual("cus_5GC5XeHUC4TmO9");
            _invoice.InvoiceId.ShouldEqual("in_150wVl2eZvKYlo2COqibpian");
        };
    }
}