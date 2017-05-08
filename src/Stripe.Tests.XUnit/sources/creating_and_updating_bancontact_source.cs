using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_bancontact_source
    {
        private StripeSource Source { get; set; }

        public creating_and_updating_bancontact_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Bancontact,
                Amount = 500,
                Currency = "eur",
                Owner = new StripeSourceOwner { Name = "Joe Biden" },
                RedirectReturnUrl = "http://no.where/webhooks",
                BancontactStatementDescriptor = "test statement descriptor"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(options);
        }

        [Fact]
        public void source_has_correct_parameters()
        {
            Source.Should().NotBeNull();
            Source.Bancontact.Should().NotBeNull();
        }
    }
}
