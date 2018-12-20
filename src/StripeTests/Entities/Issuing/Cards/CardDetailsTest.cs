namespace StripeTests.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Issuing;
    using Xunit;

    public class CardDetailsTest : BaseStripeTest
    {
        public CardDetailsTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.issuing.card_details.json");
            var cardDetails = JsonConvert.DeserializeObject<CardDetails>(json);
            Assert.NotNull(cardDetails);
            Assert.IsType<CardDetails>(cardDetails);
            Assert.Equal("issuing.card_details", cardDetails.Object);

            Assert.NotNull(cardDetails.Card);
            Assert.Equal("issuing.card", cardDetails.Card.Object);
        }
    }
}
