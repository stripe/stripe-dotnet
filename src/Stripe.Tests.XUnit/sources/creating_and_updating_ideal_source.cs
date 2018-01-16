using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_ideal_source
    {
        private StripeSource Source { get; set; }
        private StripeSourceCreateOptions SourceCreateOptions { get; set; }

        public creating_and_updating_ideal_source()
        {
            SourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Ideal,
                IdealBank = "ing",
                StatementDescriptor = "finished",
                Amount = 2001,
                Currency = "eur",
                RedirectReturnUrl = "http://no.where/webhooks"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(SourceCreateOptions);
        }

        [Fact]
        public void source_has_correct_parameters()
        {
            Source.Should().NotBeNull();
            Source.StatementDescriptor.ShouldBeEquivalentTo(SourceCreateOptions.StatementDescriptor);
            Source.Ideal.Should().NotBeNull();
            Source.Ideal.Bank.ShouldBeEquivalentTo("ing");
        }
    }
}
