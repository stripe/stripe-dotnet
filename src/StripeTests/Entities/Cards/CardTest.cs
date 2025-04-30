namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CardTest : BaseStripeTest
    {
        public CardTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.customer_card.json");
            var card = JsonConvert.DeserializeObject<Card>(json);
            Assert.NotNull(card);
            Assert.IsType<Card>(card);
            Assert.NotNull(card.Id);
            Assert.Equal("card", card.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            var json = GetResourceAsString("api_fixtures.customer_card_with_expansion.json");
            var card = JsonConvert.DeserializeObject<Card>(json);
            Assert.NotNull(card);
            Assert.IsType<Card>(card);
            Assert.NotNull(card.Id);
            Assert.Equal("card", card.Object);

            Assert.NotNull(card.Customer);
            Assert.Equal("customer", card.Customer.Object);
        }
    }
}
