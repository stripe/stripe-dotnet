namespace StripeTests.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Issuing;
    using Xunit;

    public class CardDetailsTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.issuing.card_details.json");
            var cardDetails = Mapper<CardDetails>.MapFromJson(json);
            Assert.NotNull(cardDetails);
            Assert.IsType<CardDetails>(cardDetails);
            Assert.Equal("issuing.card_details", cardDetails.Object);

            Assert.NotNull(cardDetails.Card);
            Assert.Equal("issuing.card", cardDetails.Card.Object);
        }
    }
}
