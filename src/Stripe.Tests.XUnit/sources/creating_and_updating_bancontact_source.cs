using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_bancontact_source
    {
        private StripeSource Source { get; set; }
        private StripeSourceCreateOptions SourceCreateOptions { get; set; }

        public creating_and_updating_bancontact_source()
        {
            SourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Bancontact,
                Amount = 500,
                Currency = "eur",
                Owner = new StripeSourceOwner { Name = "Joe Biden" },
                RedirectReturnUrl = "http://no.where/webhooks",
                StatementDescriptor = "test statement descriptor",
                BancontactPreferredLanguage = "FR"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(SourceCreateOptions);
        }

        [Fact]
        public void source_has_correct_parameters()
        {
            Source.Should().NotBeNull();
            Source.StatementDescriptor.Should().Be(SourceCreateOptions.StatementDescriptor);
            Source.Bancontact.Should().NotBeNull();
            Source.Bancontact.PreferredLanguage.Should().Be("FR");
        }
    }
}
