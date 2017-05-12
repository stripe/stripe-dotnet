using FluentAssertions;
using Stripe.Tests.Xunit;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_a_card_token
    {
        private StripeToken Token { get; set; }

        public creating_a_card_token()
        {
            Token = new StripeTokenService(Cache.ApiKey).CreateAsync(
                new StripeTokenCreateOptions
                {
                    Card = new StripeCreditCardOptions
                    {
                        Name = "Jason Isbell",
                        AddressCity = "Green Hill",
                        AddressState = "AL",
                        AddressLine1 = "I could ask?",
                        AddressLine2 = "",
                        AddressZip = "35636",
                        AddressCountry = "US",
                        Cvc = "123",
                        ExpirationMonth = 10,
                        ExpirationYear = 2025,
                        Number = "4242424242424242"
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
        public void has_a_fingerprint()
        {
            Token.StripeCard.Fingerprint.Should().NotBeNull();
        }
    }
}
