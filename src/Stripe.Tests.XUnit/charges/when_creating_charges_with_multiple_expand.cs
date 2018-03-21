using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_creating_charges_with_multiple_expand
    {
        private static StripeCharge Charge;

        public when_creating_charges_with_multiple_expand()
        {
            var accountService = new StripeAccountService(Cache.ApiKey);
            var account = accountService.Create(new StripeAccountCreateOptions
            {
                Type = StripeAccountType.Custom
            });

            var chargeOptions = new StripeChargeCreateOptions
            {
                SourceTokenOrExistingSourceId = "tok_visa",
                ApplicationFee = 10,
                Amount = 100,
                Currency = "usd",
                Destination = account.Id,
            };
            chargeOptions.AddExpand("balance_transaction");
            chargeOptions.AddExpand("transfer.balance_transaction.source");
            chargeOptions.AddExpand("destination");

            Charge = new StripeChargeService(Cache.ApiKey).Create(chargeOptions);

            accountService.Delete(account.Id);
        }


        [Fact]
        public void should_have_all_objects_expanded()
        {
            Charge.BalanceTransactionId.Should().Be(Charge.BalanceTransaction.Id);
            Charge.DestinationId.Should().Be(Charge.Destination.Id);
            Charge.Transfer.BalanceTransaction.Source.Id.Should().Be(Charge.Transfer.Id);
        }
    }
}
