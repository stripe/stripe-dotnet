using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    /// <summary>
    /// this test only runs when recipients is turned on or your account is gated in 
    /// </summary>
    public class creating_a_recipient_transfer
    {
        public creating_a_recipient_transfer()
        {
            // just make sure there's money in the account
            new StripeChargeService(Cache.ApiKey).Create(new StripeChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                SourceCard = new SourceCard
                {
                    Number = "4000000000000077",
                    ExpirationMonth = "10",
                    ExpirationYear = "2019",
                    Cvc = "123"
                }
            });

            // create a new recipient with a bank account
            var recipient = new StripeRecipientService(Cache.ApiKey).Create(
                new StripeRecipientCreateOptions
                {
                    Name = "Transfer McGee",
                    Type = "individual",
                    TaxId = "000000000",
                    BankAccount = new StripeBankAccountOptions()
                    {
                        AccountNumber = "000123456789",
                        RoutingNumber = "110000000",
                        Country = "US"
                    },
                    Email = "transfer@mcgee.com",
                    Description = "fake account for testing transfers to recipients",
                }
            );

            // transfer 10 cents to that recipient
            var transfer = new StripeTransferService(Cache.ApiKey).Create(
                new StripeTransferCreateOptions
                {
                    Recipient = recipient.Id,
                    Amount = 10,
                    Currency = "usd"
                }
            );

            var balanceService = new StripeBalanceService(Cache.ApiKey);
            //balanceService.ExpandSource = true;

            balanceService.Get(transfer.BalanceTransactionId);
        }

        [Fact(Skip = "This will only work when gated into the legacy recipient mode")]
        public void not_null()
        {
            // do a real assert if this gets implemented
            // don't forget to move the constructor code to a fixture if asserting more than one fact
            1.Should().Be(1);
        }
    }
}
