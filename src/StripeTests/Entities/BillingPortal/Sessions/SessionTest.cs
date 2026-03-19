namespace StripeTests.BillingPortal
{
    using System.Text.Json;
    using Stripe;
    using Stripe.BillingPortal;
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
            var json = GetResourceAsString("api_fixtures.billing_portal.session.json");
            var session = JsonSerializer.Deserialize<Session>(json);
            Assert.NotNull(session);
            Assert.IsType<Session>(session);
            Assert.NotNull(session.Id);
            Assert.Equal("billing_portal.session", session.Object);
        }
    }
}
