using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    /// <summary>
    /// https://dashboard.stripe.com/account/details
    /// this test requires the account to be activated first. it was activated by using the routing number 111904943
    /// and the bank account number 000123456789. also, automatic transfers disabled https://dashboard.stripe.com/account/transfers
    /// </summary>
    public class creating_and_updating_payouts : IClassFixture<account_fixture>, IClassFixture<payouts_fixture>
    {
        private readonly account_fixture account_fixture;
        private readonly payouts_fixture fixture;

        public creating_and_updating_payouts(account_fixture accountFixture, payouts_fixture payoutsFixture)
        {
            account_fixture = accountFixture;
            fixture = payoutsFixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Payout.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_id()
        {
            fixture.Payout.Id.Should().StartWith("po_");
        }

        [Fact]
        public void created_has_the_right_amount()
        {
            fixture.Payout.Amount.Should().Be(fixture.PayoutCreateOptions.Amount);
        }

        [Fact]
        public void created_has_the_right_statement_descriptor()
        {
            fixture.Payout.StatementDescriptor.Should().Be(fixture.PayoutCreateOptions.StatementDescriptor);
        }

        [Fact]
        public void get_is_not_null()
        {
            fixture.PayoutRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_the_right_metadata()
        {
            fixture.PayoutUpdated.Metadata.Keys.Should().BeEquivalentTo(fixture.PayoutUpdateOptions.Metadata.Keys);
        }

    }
}
