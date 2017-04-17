using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_sofort_source
    {
        private StripeSource Source { get; set; }

        public creating_and_updating_sofort_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Sofort,
                SofortCountry = "DE",
                SofortStatementDescriptor = "soforty!",
                Amount = 500,
                Currency = "eur",
                RedirectReturnUrl = "http://no.where/webhooks"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(options);
        }

        [Fact]
        public void source_has_correct_parameters()
        {
            Source.Should().NotBeNull();
            Source.Sofort.Country.Should().Be("DE");
        }
    }
}
