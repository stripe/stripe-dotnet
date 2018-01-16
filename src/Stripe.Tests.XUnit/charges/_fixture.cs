using System;

namespace Stripe.Tests.Xunit
{
    public class charges_fixture : IDisposable
    {
        public StripeChargeListOptions ChargeListOptions { get; set; }
        public StripeChargeUpdateOptions ChargeUpdateOptions { get; set; }
        public StripeChargeCaptureOptions ChargeCaptureOptions { get; set; }

        public StripeCharge Charge { get; set; }
        public StripeList<StripeCharge> Charges { get; set; }
        public StripeCharge UpdatedCharge { get; set; }
        public StripeCharge UncapturedCharge { get; set; }
        public StripeCharge CapturedCharge { get; set; }

        public charges_fixture()
        {
            // make sure there's a charge
            Charge = Cache.GetStripeCharge(Cache.ApiKey);

            ChargeListOptions = new StripeChargeListOptions();

            var service = new StripeChargeService(Cache.ApiKey);
            Charges = service.List(ChargeListOptions);

            ChargeUpdateOptions = new StripeChargeUpdateOptions
            {
                Description = "updatd description",
                // setting the updated shipping object to the same object used for the create charge 
                // i attempted to just create a new shipping object and set one property,
                // but it threw an error 'name' was not supplied (which was on the original)
                Shipping = Cache.GetStripeChargeCreateOptions().Shipping
            };

            ChargeUpdateOptions.Shipping.Phone = "8675309";
            ChargeUpdateOptions.Shipping.TrackingNumber = "56789";

            UpdatedCharge = service.Update(Charge.Id, ChargeUpdateOptions);

            UncapturedCharge = Cache.GetStripeChargeUncaptured(Cache.ApiKey);

            ChargeCaptureOptions = new StripeChargeCaptureOptions
            {
                Amount = 123,
                StatementDescriptor = "CapturedCharge"
            };
            CapturedCharge = service.Capture(UncapturedCharge.Id, ChargeCaptureOptions);
        }

        public void Dispose() { }
    }
}
