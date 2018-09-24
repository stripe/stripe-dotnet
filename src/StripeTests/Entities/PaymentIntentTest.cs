namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
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
            Assert.Equal("card", intent.Source.Card.Object);

            Assert.NotNull(intent.TransferData);
            Assert.NotNull(intent.TransferData.Destination);
            Assert.Equal("account", intent.TransferData.Destination.Object);
        }

        [Fact]
        public void DeserializeNextSourceAction()
        {
            var json = GetResourceAsString("api_fixtures.payment_intent_with_next_source_action.json");
            var intent = Mapper<PaymentIntent>.MapFromJson(json);

            Assert.NotNull(intent);
            Assert.IsType<PaymentIntent>(intent);
            Assert.NotNull(intent.Id);
            Assert.Equal("payment_intent", intent.Object);

            Assert.Equal(PaymentIntentSourceActionType.AuthorizeWithUrl, intent.NextSourceAction.Type);
            Assert.Equal("https://stripe.com", intent.NextSourceAction.AuthorizeWithUrl.Url);
        }
    }
}
