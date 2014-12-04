using System;
using System.IO;
using Machine.Specifications;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stripe.Tests
{
    public class when_mapping_application_fee
    {
        private static StripeApplicationFee _fee;

        static when_mapping_application_fee()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        Because of = () =>
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../infrastructure", "test_data", "application_fee.json");
            var json = File.ReadAllText(path);
            _fee = Mapper<StripeApplicationFee>.MapFromJson(json);
        };

        It should_not_throw_exception = () =>
        {
            _fee.AccountId.ShouldEqual("acct_1032D82eZvKYlo2C");
            _fee.BalanceTransactionId.ShouldEqual("txn_153Otp2eZvKYlo2CgqvbRlEA");
            _fee.ChargeId.ShouldEqual("ch_155fsN2eZvKYlo2CGqYDyqla");
        };
    }
}