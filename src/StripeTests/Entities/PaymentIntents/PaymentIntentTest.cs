namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class PaymentIntentTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/payment_intents/pi_123");
            var intent = Mapper<PaymentIntent>.MapFromJson(json);
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

            string json = GetFixture("/v1/payment_intents/pi_123", expansions);
            var intent = Mapper<PaymentIntent>.MapFromJson(json);
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
            var intent = Mapper<PaymentIntent>.MapFromJson(json);

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
            var intent = Mapper<PaymentIntent>.MapFromJson(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.Equal(PaymentIntentSourceActionType.AuthorizeWithUrl, intent.NextSourceAction.Type);
            var authorizeWithUrl = intent.NextSourceAction.Value as PaymentIntentSourceActionAuthorizeWithUrl;
            Assert.NotNull(authorizeWithUrl);
            Assert.Equal("https://stripe.com", authorizeWithUrl.Url);
        }

        [Fact]
        public void DeserializeNextSourceActionUnknown()
        {
            var json = GetResourceAsString("api_fixtures.payment_intent.action_unknown.json");
            var intent = Mapper<PaymentIntent>.MapFromJson(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.Equal(PaymentIntentSourceActionType.Unknown, intent.NextSourceAction.Type);
            Assert.Null(intent.NextSourceAction.Value);
        }
    }
}
