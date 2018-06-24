using System;
using System.Collections.Generic;

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
        public StripeCharge Level3Charge { get; set; }

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

            // Create a charge with Level 3 data
            var chargeLevel3Options = Cache.GetStripeChargeCreateOptions();
            chargeLevel3Options.Amount = 11700;
            chargeLevel3Options.Level3 = new StripeChargeLevel3Options
            {
                MerchantReference = "1234",
                ShippingAddressZip = "94110",
                ShippingAmount = 700,
                LineItems = new List<StripeChargeLevel3LineItemOptions>
                {
                    new StripeChargeLevel3LineItemOptions
                    {
                        DiscountAmount = 200,
                        ProductCode = "1234",
                        ProductDescription = "description 1",
                        Quantity = 2,
                        TaxAmount = 200,
                        UnitCost = 1000,
                    },
                    new StripeChargeLevel3LineItemOptions
                    {
                        DiscountAmount = 300,
                        ProductCode = "1235",
                        ProductDescription = "description 2",
                        Quantity = 3,
                        TaxAmount = 300,
                        UnitCost = 3000,
                    },
                },
            };
            Level3Charge = service.Create(chargeLevel3Options);
        }

        public void Dispose() { }
    }
}
