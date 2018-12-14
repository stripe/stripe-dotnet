namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class CardListOptionsTest : BaseStripeTest
    {
        private readonly CardService service;

        public CardListOptionsTest()
        {
            this.service = new CardService();
        }

        [Fact]
        public void SerializeObjectProperly()
        {
            var options = new CardListOptions();

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?object=card", url);
        }
    }
}
