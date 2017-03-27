using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class canceling_a_payout : IClassFixture<account_fixture>, IClassFixture<payouts_fixture>
    {
        private readonly account_fixture account_fixture;
        private readonly payouts_fixture fixture;

        public canceling_a_payout(account_fixture accountFixture, payouts_fixture payoutsFixture)
        {
            account_fixture = accountFixture;
            fixture = payoutsFixture;
        }

        [Fact]
        public void should_throw_exception_if_not_pending()
        {
            var exception = Assert.Throws<StripeException>(() =>
                (new StripePayoutService(Cache.ApiKey).Cancel(fixture.Payout.Id))
            );

            exception.Message.Should().Be("Payouts can only be canceled while they are pending.");
        }
    }
}
