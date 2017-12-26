using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stripe.Tests.Xunit
{
    public class connect_fixture : IDisposable
    {
        public StripeAccount Account { get; }
        public StripeCharge Charge { get; }
        public StripeApplicationFee ApplicationFee { get; }

        public connect_fixture()
        {
            var accountService = new StripeAccountService(Cache.ApiKey);
            var accountCreateOptions = new StripeAccountCreateOptions
            {
                DefaultCurrency = "usd",
                Email = "cu_xxxxxx@gmail.com",
                Type = StripeAccountType.Custom
            };
            Account = accountService.Create(accountCreateOptions);

            var chargeService = new StripeChargeService(Cache.ApiKey);
            chargeService.ExpandApplication = true;
            chargeService.ExpandApplicationFee = true;
            Charge = chargeService.Create(
                new StripeChargeCreateOptions
                {
                    SourceTokenOrExistingSourceId = "tok_visa",
                    ApplicationFee = 10,
                    Amount = 100,
                    Currency = "usd"
                }, 
                new StripeRequestOptions
                {
                    StripeConnectAccountId = Account.Id
                }
            );

            var applicationFeeService = new StripeApplicationFeeService(Cache.ApiKey);
            applicationFeeService.ExpandApplication = true;
            ApplicationFee = applicationFeeService.Get(Charge.ApplicationFeeId);
        }

        public void Dispose()
        {
            new StripeAccountService(Cache.ApiKey).Delete(Account.Id);
        }
    }
}
