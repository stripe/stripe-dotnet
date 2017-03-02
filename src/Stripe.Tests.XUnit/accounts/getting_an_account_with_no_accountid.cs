using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class getting_an_account_with_no_accountid
    {
        private StripeAccount Account { get; }

        public getting_an_account_with_no_accountid()
        {
            Account = new StripeAccountService(Cache.ApiKey).Get();
        }

        [Fact]
        public void returns_your_account()
        {
            Account.Should().NotBeNull();
            Account.Id.Should().StartWith("acct_");
        }
    }
}
