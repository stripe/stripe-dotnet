using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_bitcoin_source
    {
        private StripeSource Source { get; set; }

        public creating_and_updating_bitcoin_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Bitcoin,
                Amount = 100101,
                Currency = "usd",
                Owner = new StripeSourceOwner
                {
                    Name = "Satoshi Nakamoto",
                    Email = "nobody_knows@gmail.com"
                },
                RedirectReturnUrl = "http://no.where/webhooks"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(options);
        }

        [Fact]
        public void source_should_not_be_null()
        {
            Source.Should().NotBeNull();
            Source.Bitcoin.Should().NotBeNull();
        }
    }
}
