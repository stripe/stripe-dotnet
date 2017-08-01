using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_card_source
    {
        private StripeSource Source { get; set; }

        public creating_and_updating_card_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Amount = 100,
                Currency = "usd",
                Token = "tok_visa",
                RedirectReturnUrl = "http://no.where/webhooks"
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
