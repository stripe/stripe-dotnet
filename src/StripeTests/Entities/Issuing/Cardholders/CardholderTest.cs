namespace StripeTests.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Issuing;
    using Xunit;

    public class CardholderTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/cardholders/ich_123");
            var cardholder = JsonConvert.DeserializeObject<Cardholder>(json);
            Assert.NotNull(cardholder);
            Assert.IsType<Cardholder>(cardholder);
            Assert.NotNull(cardholder.Id);
            Assert.Equal("issuing.cardholder", cardholder.Object);
        }
    }
}
