using System;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class charging_from_another_account
    {
        private StripeApplicationFee _appFee;

        public charging_from_another_account()
        {
            var anotherAccount = new StripeAccountService(Cache.ApiKey).Create(new StripeAccountCreateOptions
                {
                    DefaultCurrency = "usd",
                    Email = "cu_xxxxxx@gmail.com",
                    Type = StripeAccountType.Custom
            }
            );

            var chargeService = new StripeChargeService(Cache.ApiKey);
            chargeService.ExpandApplicationFee = true;

            var charge = chargeService.Create(
                new StripeChargeCreateOptions
                {
                    SourceTokenOrExistingSourceId = "tok_visa",
                    ApplicationFee = 10,
                    Amount = 100,
                    Currency = "usd"
                }, 
                new StripeRequestOptions
                {
                    StripeConnectAccountId = anotherAccount.Id
                }
            );

            var appFeeService = new StripeApplicationFeeService(Cache.ApiKey);
            appFeeService.ExpandApplication = true;

            _appFee = appFeeService.Get(charge.ApplicationFeeId);
        }

        [Fact]
        public void it_should_have_connected_app_on_app_fee()
        {
            _appFee.ApplicationId.Should().StartWith("ca_");
            _appFee.Application.Should().NotBeNull();
        }
    }
}
