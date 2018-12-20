namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class PaymentIntentTest : BaseStripeTest
    {
        public PaymentIntentTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/payment_intents/pi_123");
            var intent = JsonConvert.DeserializeObject<PaymentIntent>(json);
            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);
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
              "transfer_data.destination",
            };

            string json = this.GetFixture("/v1/payment_intents/pi_123", expansions);
            var intent = JsonConvert.DeserializeObject<PaymentIntent>(json);
            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.NotNull(intent.Application);
            Assert.Equal("application", intent.Application.Object);

            Assert.NotNull(intent.Customer);
            Assert.Equal("customer", intent.Customer.Object);

            Assert.NotNull(intent.TransferData);
            Assert.NotNull(intent.TransferData.Destination);
            Assert.Equal("account", intent.TransferData.Destination.Object);
        }

        [Fact]
        public void DeserializeNextSourceActionNull()
        {
            var json = GetResourceAsString("api_fixtures.payment_intent.action_null.json");
            var intent = JsonConvert.DeserializeObject<PaymentIntent>(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.Null(intent.NextSourceAction);
        }

        [Fact]
        public void DeserializeNextSourceActionAuthorizeWithUrl()
        {
            var json = GetResourceAsString("api_fixtures.payment_intent.action_authorize_with_url.json");
            var intent = JsonConvert.DeserializeObject<PaymentIntent>(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.Equal("authorize_with_url", intent.NextSourceAction.Type);
            Assert.NotNull(intent.NextSourceAction.AuthorizeWithUrl);
            Assert.Equal("https://stripe.com", intent.NextSourceAction.AuthorizeWithUrl.Url);
            Assert.Equal("https://stripe.com/return", intent.NextSourceAction.AuthorizeWithUrl.ReturnUrl);
        }

        [Fact]
        public void DeserializeNextSourceActionUnknown()
        {
            var json = GetResourceAsString("api_fixtures.payment_intent.action_unknown.json");
            var intent = JsonConvert.DeserializeObject<PaymentIntent>(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.Equal("foo", intent.NextSourceAction.Type);
            Assert.Null(intent.NextSourceAction.AuthorizeWithUrl);
        }

        [Fact]
        public void DeserializeLastPaymentError()
        {
            var json = GetResourceAsString("api_fixtures.payment_intent.last_payment_error.json");
            var intent = JsonConvert.DeserializeObject<PaymentIntent>(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            var lastPaymentError = intent.LastPaymentError;
            Assert.NotNull(lastPaymentError);
            Assert.Equal("generic_decline", lastPaymentError.DeclineCode);
            Assert.IsType<Card>(lastPaymentError.Source);
            Assert.Equal("card_123", lastPaymentError.Source.Id);
        }
    }
}
