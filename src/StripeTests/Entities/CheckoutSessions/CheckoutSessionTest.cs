namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CheckoutSessionTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.checkout_session.json");
            var session = JsonConvert.DeserializeObject<CheckoutSession>(json);
            Assert.NotNull(session);
            Assert.IsType<CheckoutSession>(session);
            Assert.NotNull(session.Id);
            Assert.Equal("checkout_session", session.Object);
        }
    }
}
