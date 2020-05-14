namespace StripeTests.Checkout
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Checkout;
    using Xunit;

    public class SessionTest : BaseStripeTest
    {
        public SessionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/checkout/sessions/cs_123");
            var session = JsonConvert.DeserializeObject<Session>(json);
            Assert.NotNull(session);
            Assert.IsType<Session>(session);
            Assert.NotNull(session.Id);
            Assert.Equal("checkout.session", session.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "customer",
              "payment_intent",
              "line_items",
              "setup_intent",
              "subscription",
            };

            string json = this.GetFixture("/v1/checkout/sessions/cs_123", expansions);
            var session = JsonConvert.DeserializeObject<Session>(json);
            Assert.NotNull(session);
            Assert.IsType<Session>(session);
            Assert.NotNull(session.Id);
            Assert.Equal("checkout.session", session.Object);

            Assert.NotNull(session.Customer);
            Assert.Equal("customer", session.Customer.Object);

            Assert.NotNull(session.LineItems);
            Assert.Equal("item", session.LineItems.Data[0].Object);

            Assert.NotNull(session.PaymentIntent);
            Assert.Equal("payment_intent", session.PaymentIntent.Object);

            Assert.NotNull(session.SetupIntent);
            Assert.Equal("setup_intent", session.SetupIntent.Object);

            Assert.NotNull(session.Subscription);
            Assert.Equal("subscription", session.Subscription.Object);
        }
    }
}
