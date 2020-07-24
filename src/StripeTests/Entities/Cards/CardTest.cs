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
            string json = this.GetFixture("/v1/customers/cus_123/cards/card_123");
            var card = JsonConvert.DeserializeObject<Card>(json);
            Assert.NotNull(card);
            Assert.IsType<Card>(card);
            Assert.NotNull(card.Id);
            Assert.Equal("card", card.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "customer",
            };

            string json = this.GetFixture("/v1/customers/cus_123/cards/card_123", expansions);
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
