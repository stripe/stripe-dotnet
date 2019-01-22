namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.Extensions;
    using Xunit;

    public class CardListOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeObjectProperly()
        {
            var options = new CardListOptions();

            Assert.Equal("object=card", options.ToQueryString());
        }
    }
}
