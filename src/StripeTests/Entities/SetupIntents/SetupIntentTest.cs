namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SetupIntentTest : BaseStripeTest
    {
        public SetupIntentTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/setup_intents/seti_123");
            var intent = JsonConvert.DeserializeObject<SetupIntent>(json);
            Assert.NotNull(intent);
            Assert.IsType<SetupIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            // Do not test expanding `source` as it is not supported by stripe-mock
            // and will be auto-expanded in a future API version.
            string[] expansions =
            {
              "application",
              "customer",
              "mandate",
              "on_behalf_of",
              "payment_method",
              "single_use_mandate",
            };

            string json = this.GetFixture("/v1/setup_intents/seti_123", expansions);
            var intent = JsonConvert.DeserializeObject<SetupIntent>(json);
            Assert.NotNull(intent);
            Assert.IsType<SetupIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("setup_intent", intent.Object);

            Assert.NotNull(intent.Application);
            Assert.Equal("application", intent.Application.Object);

            Assert.NotNull(intent.Customer);
            Assert.Equal("customer", intent.Customer.Object);

            Assert.NotNull(intent.Mandate);
            Assert.Equal("mandate", intent.Mandate.Object);

            Assert.NotNull(intent.OnBehalfOf);
            Assert.Equal("account", intent.OnBehalfOf.Object);

            Assert.NotNull(intent.SingleUseMandate);
            Assert.Equal("mandate", intent.SingleUseMandate.Object);

            Assert.NotNull(intent.PaymentMethod);
            Assert.Equal("payment_method", intent.PaymentMethod.Object);
        }
    }
}
