using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class getting_external_accounts : test
    {
        private StripeAccount RetrievedAccount { get; }

        public getting_external_accounts()
        {
            var newAccount = Cache.GetManagedAccount();

            RetrievedAccount = new StripeAccountService(Cache.ApiKey).Get(newAccount.Id);
        }

        [Fact]
        public void has_object()
        {
            RetrievedAccount.ExternalAccounts.Object.Should().NotBeNull();
        }

        [Fact]
        public void has_total_count()
        {
            RetrievedAccount.ExternalAccounts.TotalCount.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void has_url()
        {
            RetrievedAccount.ExternalAccounts.Url.Should().NotBeNull();
        }
    }
}

