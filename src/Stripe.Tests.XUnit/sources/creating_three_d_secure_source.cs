using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_three_d_secure_source
    {
        private StripeSource Source { get; }
        private StripeSource ThreeDSecure { get; }
        private StripeCustomer Customer { get; }
        private StripeSource SourceCustomer { get; }
        private StripeSource ThreeDSecureCustomer { get; }

        public creating_three_d_secure_source()
        {
            var sourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Amount = 1234,
                Currency = "eur",
                RedirectReturnUrl = "http://no.where/webhooks",
                Card = new StripeCreditCardOptions
                {
                    // Using PAN as we don't have a 3DS test token yet
                    Number = "4000000000003063",
                    ExpirationMonth = 12,
                    ExpirationYear = 2020
                }
            };

            var threeDSCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.ThreeDSecure,
                Amount = 8675309,
                Currency = "eur",
                RedirectReturnUrl = "http://no.where/webhooks",
            };

            var sourceService = new StripeSourceService(Cache.ApiKey);
            var customerService = new StripeCustomerService(Cache.ApiKey);
            Customer = customerService.Create(new StripeCustomerCreateOptions{});

            Source = sourceService.Create(sourceCreateOptions);
            threeDSCreateOptions.ThreeDSecureCardOrSourceId = Source.Id;
            ThreeDSecure = sourceService.Create(threeDSCreateOptions);

            SourceCustomer = sourceService.Create(sourceCreateOptions);
            var SourceAttachOptions = new StripeSourceAttachOptions
            {
                Source = SourceCustomer.Id
            };
            sourceService.Attach(Customer.Id, SourceAttachOptions);

            threeDSCreateOptions.ThreeDSecureCardOrSourceId = SourceCustomer.Id;
            threeDSCreateOptions.ThreeDSecureCustomer = Customer.Id;
            ThreeDSecureCustomer = sourceService.Create(threeDSCreateOptions);


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

            SourceCustomer.Should().NotBeNull();
            ThreeDSecureCustomer.Should().NotBeNull();
            ThreeDSecureCustomer.ThreeDSecure.CardId.Should().Be(SourceCustomer.Id);
            ThreeDSecureCustomer.ThreeDSecure.CustomerId.Should().Be(Customer.Id);
        }
    }
}
