using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_three_d_secure_source
    {
        private StripeSource Source { get; }
        private StripeSource ThreeDSecure { get; }

        public creating_three_d_secure_source()
        {
            Source = new StripeSourceService(Cache.ApiKey).Create(
                new StripeSourceCreateOptions
                {
                    Type = StripeSourceType.Card,
                    Amount = 8675309,
                    Currency = "eur",
                    RedirectReturnUrl = "http://no.where/webhooks",
                    Card = new StripeCreditCardOptions
                    {
                        // Using PAN as we don't have a 3DS test token yet
                        Number = "4000000000003063",
                        ExpirationMonth = 12,
                        ExpirationYear = 2020
                    }
                }
            );

            ThreeDSecure = new StripeSourceService(Cache.ApiKey).Create(
                new StripeSourceCreateOptions
                {
                    Type = StripeSourceType.ThreeDSecure,
                    Amount = 8675309,
                    Currency = "eur",
                    RedirectReturnUrl = "http://no.where/webhooks",
                    ThreeDSecureCardOrSourceId = Source.Id
                }
            );

            // from here, you have to go to the threeDSecure.Redirect.Url and click success

            //var charge = new StripeChargeService(Cache.ApiKey).Create(
            //    new StripeChargeCreateOptions
            //    {
            //        Amount = 8675309,
            //        Currency = "eur",
            //        SourceTokenOrExistingSourceId = threeDSecure.Id
            //    }
            //);
        }

        [Fact]
        public void should_setup_for_3d_secure()
        {
            Source.Should().NotBeNull();
            ThreeDSecure.Should().NotBeNull();
            ThreeDSecure.Redirect.Url.Should().NotBeNull();
        }
    }
}
