using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class listing_cards_on_customer
    {
        public StripeList<StripeCard> ListCards { get; }

        public listing_cards_on_customer()
        {
            var customerService = new StripeCustomerService(Cache.ApiKey);
            var bankAccountService = new BankAccountService(Cache.ApiKey);
            var cardService = new StripeCardService(Cache.ApiKey);

            var CustomerCreateOptions = new StripeCustomerCreateOptions
            {
                Email = "jenny@example.com",
                SourceToken = "tok_visa",
            };
            var Customer = customerService.Create(CustomerCreateOptions);

            var BankAccountCreateOptions = new BankAccountCreateOptions
            {
                SourceBankAccount = new SourceBankAccount()
                {
                    RoutingNumber = "110000000",
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Jenny Rosen",
                    AccountHolderType = BankAccountHolderType.Individual,
                }
            };
            var BankAccount = bankAccountService.Create(Customer.Id, BankAccountCreateOptions);

            ListCards = cardService.List(Customer.Id);
        }

        [Fact]
        public void list_contains_only_one_element()
        {
            ListCards.Data.Count.Should().Be(1);
        }

        [Fact]
        public void list_element_is_a_card()
        {
            var card = ListCards.Data[0];
            card.Object.Should().Be("card");
            card.Brand.Should().Be("Visa");
        }
    }
}
