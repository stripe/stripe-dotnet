namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SubscriptionTest : BaseStripeTest
    {
        public SubscriptionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/subscriptions/sub_123");
            var subscription = JsonConvert.DeserializeObject<Subscription>(json);
            Assert.NotNull(subscription);
            Assert.IsType<Subscription>(subscription);
            Assert.NotNull(subscription.Id);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "customer",
              "default_payment_method",
              "latest_invoice",
            };

            string json = this.GetFixture("/v1/subscriptions/sub_123", expansions);
            var subscription = JsonConvert.DeserializeObject<Subscription>(json);
            Assert.NotNull(subscription);
            Assert.IsType<Subscription>(subscription);
            Assert.NotNull(subscription.Id);
            Assert.Equal("subscription", subscription.Object);

            Assert.NotNull(subscription.Customer);
            Assert.Equal("customer", subscription.Customer.Object);

            Assert.NotNull(subscription.DefaultPaymentMethod);
            Assert.Equal("payment_method", subscription.DefaultPaymentMethod.Object);

            Assert.NotNull(subscription.LatestInvoice);
            Assert.Equal("invoice", subscription.LatestInvoice.Object);
        }
    }
}
