using System;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class getting_an_account_with_no_accountid : test
    {
        private StripeAccount RetrievedAccount { get; }
        private StripeAccount RetrievedAccountAsync { get; }

        public getting_an_account_with_no_accountid()
        {
            RetrievedAccount = new StripeAccountService(_stripe_api_key).Get();
            RetrievedAccountAsync = new StripeAccountService(_stripe_api_key).GetAsync().Result;
        }

        [Fact]
        public void has_total_count()
        {
            RetrievedAccount.Should().NotBeNull();
            RetrievedAccountAsync.Should().NotBeNull();
        }

        [Fact]
        public void has_account_id()
        {
            RetrievedAccount.Id.Should().StartWith("acct_");
            RetrievedAccountAsync.Id.Should().StartWith("acct_");
        }
    }
}
