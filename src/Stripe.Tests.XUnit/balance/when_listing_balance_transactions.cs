using FluentAssertions;
using Stripe.Tests.Xunit;
using Xunit;

namespace Stripe.Tests.XUnit
{
    public class when_listing_balance_transactions
    { 
        public when_listing_balance_transactions()
        {
            if (!Cache.FirstRun) return;

            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
        }

        [Fact]
        public void it_should_have_the_total_count()
        {
            var result = new StripeBalanceService(Cache.ApiKey).List(new StripeBalanceTransactionListOptions { IncludeTotalCount = true } );

            result.TotalCount.Should().BeGreaterOrEqualTo(4);
            result.Data.Count.Should().BeGreaterOrEqualTo(4);
        }
    }
}
