namespace StripeTests.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Issuing;
    using Xunit;

    public class CardholderTest : BaseStripeTest
    {
        public CardholderTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/issuing/cardholders/ich_123");
            var cardholder = JsonConvert.DeserializeObject<Cardholder>(json);
            Assert.NotNull(cardholder);
            Assert.IsType<Cardholder>(cardholder);
            Assert.NotNull(cardholder.Id);
            Assert.Equal("issuing.cardholder", cardholder.Object);
        }
    }
}
