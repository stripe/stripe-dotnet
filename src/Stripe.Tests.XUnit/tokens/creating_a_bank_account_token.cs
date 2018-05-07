using FluentAssertions;
using Stripe.Tests.Xunit;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_a_bank_account_token
    {
        private StripeToken Token { get; set; }

        public creating_a_bank_account_token()
        {
            Token = new StripeTokenService(Cache.ApiKey).CreateAsync(
                new StripeTokenCreateOptions
                {
                    BankAccount = new BankAccountOptions
                    {
                        AccountNumber = "000123456789",
                        Country = "US",
                        Currency = "USD",
                        RoutingNumber = "110000000",
                    }
                }
            ).Result;
        }

        [Fact]
        public void not_null()
        {
            Token.Should().NotBeNull();
        }

        [Fact]
        public void has_relevant_properties_set()
        {
            Token.Id.Should().NotBeNull();
            Token.StripeBankAccount.Id.Should().NotBeNull();
            Token.StripeBankAccount.Last4.Should().Be("6789");
            Token.StripeBankAccount.RoutingNumber.Should().Be("110000000");
        }
    }
}
