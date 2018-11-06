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
            string[] expansions =
            {
              "application",
              "customer",
              "source",
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

            Assert.NotNull(intent.Source);
            Assert.IsType<Card>(intent.Source);
            Assert.Equal("card", intent.Source.Object);

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

            Assert.Equal("authorize_with_url", intent.NextSourceAction.Type);
            Assert.NotNull(intent.NextSourceAction.AuthorizeWithUrl);
            Assert.Equal("https://stripe.com", intent.NextSourceAction.AuthorizeWithUrl.Url);
            Assert.Equal("https://stripe.com/return", intent.NextSourceAction.AuthorizeWithUrl.ReturnUrl);
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

            Assert.Equal("foo", intent.NextSourceAction.Type);
            Assert.Null(intent.NextSourceAction.AuthorizeWithUrl);
        }
    }
}
