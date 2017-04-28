using System;

namespace Stripe.Tests.Xunit
{
    public class charges_fixture : IDisposable
    {
        public StripeChargeListOptions ChargeListOptions { get; set; }

        public StripeList<StripeCharge> Charges { get; set; }

        public charges_fixture()
        {
            // make sure there's a charge
            Cache.GetStripeCharge(Cache.ApiKey);

            ChargeListOptions = new StripeChargeListOptions
            {
                IncludeTotalCount = true
            };

            var service = new StripeChargeService(Cache.ApiKey);
            Charges = service.List(ChargeListOptions);
        }

        public void Dispose()
        {
            // not implemented :(
        }
    }
}
