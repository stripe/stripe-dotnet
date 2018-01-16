using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_sofort_source
    {
        private StripeSource Source { get; set; }
        private StripeSourceCreateOptions SourceCreateOptions { get; set; }

        public creating_and_updating_sofort_source()
        {
            SourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Sofort,
                SofortCountry = "DE",
                StatementDescriptor = "soforty!",
                Amount = 500,
                Currency = "eur",
                RedirectReturnUrl = "http://no.where/webhooks"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(SourceCreateOptions);
        }

        [Fact]
        public void source_has_correct_parameters()
        {
            Source.Should().NotBeNull();
            Source.StatementDescriptor.Should().Be(SourceCreateOptions.StatementDescriptor);
            Source.Sofort.Should().NotBeNull();
            Source.Sofort.Country.Should().Be("DE");
        }
    }
}
