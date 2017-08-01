using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_reusable_card_source
    {
        private StripeSource Source { get; set; }

        public creating_reusable_card_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Usage = StripeSourceUsage.Reusable,
                Token = "tok_visa",
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(options);
        }

        [Fact]
        public void source_should_not_be_null()
        {
            Source.Should().NotBeNull();
            Source.Card.Should().NotBeNull();
        }
    }
}
