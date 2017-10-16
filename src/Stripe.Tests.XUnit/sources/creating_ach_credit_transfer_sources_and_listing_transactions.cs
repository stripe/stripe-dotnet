using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_ach_credit_transfers_sources_and_listing_transactions
    {
        public StripeSource Source { get; }
        public StripeList<StripeSourceTransaction> Transactions { get; }

        public creating_ach_credit_transfers_sources_and_listing_transactions()
        {
            var SourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.AchCreditTransfer,
                Currency = "usd",
                Owner = new StripeSourceOwner
                {
                    Email = "amount_4242@example.com"
                }
            };

            var sourceService = new StripeSourceService(Cache.ApiKey);
            var sourceTransactionService = new StripeSourceTransactionService(Cache.ApiKey);

            Source = sourceService.Create(SourceCreateOptions);
            Transactions = sourceTransactionService.List(Source.Id);
        }

        [Fact]
        public void source_is_not_null()
        {
            Source.Should().NotBeNull();
        }

        [Fact]
        public void source_has_correct_type()
        {
            Source.Type.Should().Be(StripeSourceType.AchCreditTransfer);
        }

        [Fact]
        public void transactions_is_not_null()
        {
            Transactions.Should().NotBeNull();
        }
    }
}
