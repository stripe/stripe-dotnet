using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_ideal_source
    {
        private StripeSource Source { get; set; }

        public creating_and_updating_ideal_source()
        {
            var options = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Ideal,
                IdealBank = "ing",
                IdealStatementDescriptor = "finished",
                Amount = 2001,
                Currency = "eur",
                RedirectReturnUrl = "http://no.where/webhooks"
            };

            Source = new StripeSourceService(Cache.ApiKey).Create(options);
        }

        [Fact]
        public void source_has_correct_parameters()
        {
            Source.Ideal.Should().NotBeNull();
            Source.Ideal.Bank.ShouldBeEquivalentTo("ing");
        }
    }
}
