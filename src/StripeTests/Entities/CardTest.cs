namespace StripeTests
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CardTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/customers/cus_123/cards/card_123");
            var card = Mapper<Card>.MapFromJson(json);
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
              "recipient",
            };

            string json = GetFixture("/v1/customers/cus_123/cards/card_123", expansions);
            var card = Mapper<Card>.MapFromJson(json);
            Assert.NotNull(card);
            Assert.IsType<Card>(card);
            Assert.NotNull(card.Id);
            Assert.Equal("card", card.Object);

            Assert.NotNull(card.Customer);
            Assert.Equal("customer", card.Customer.Object);

            Assert.NotNull(card.Recipient);
            Assert.Equal("recipient", card.Recipient.Object);
        }
    }
}
