using System;
using System.IO;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_charge
    {
        private static StripeCharge _charge;

        static when_mapping_charge()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "charge.json");
            var json = File.ReadAllText(path);
            _charge = Mapper<StripeCharge>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
        {
            _charge.BalanceTransactionId.ShouldEqual("txn_153Otp2eZvKYlo2CgqvbRlEA");
            _charge.CustomerId.ShouldEqual("cus_4KrhtWKRbXk69Y");
            _charge.InvoiceId.ShouldEqual("in_155eu32eZvKYlo2C28zCWkfV");
        };
    }
}