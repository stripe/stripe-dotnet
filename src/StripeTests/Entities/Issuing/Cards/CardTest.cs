namespace StripeTests.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Issuing;
    using Xunit;

    public class CardTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/cards/ic_123");
            var card = JsonConvert.DeserializeObject<Card>(json);
            Assert.NotNull(card);
            Assert.IsType<Card>(card);
            Assert.NotNull(card.Id);
            Assert.Equal("issuing.card", card.Object);

            Assert.NotNull(card.Cardholder);
            Assert.Equal("issuing.cardholder", card.Cardholder.Object);
        }
    }
}
