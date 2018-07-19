namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Issuing;
    using Xunit;

    public class CardTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/cards/ic_123");
            var card = Mapper<Card>.MapFromJson(json);
            Assert.NotNull(card);
            Assert.IsType<Card>(card);
            Assert.NotNull(card.Id);
            Assert.Equal("issuing.card", card.Object);

            Assert.NotNull(card.Cardholder);
            Assert.Equal("issuing.cardholder", card.Cardholder.Object);
        }
    }
}
