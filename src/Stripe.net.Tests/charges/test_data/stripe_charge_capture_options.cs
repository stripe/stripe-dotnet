using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_charge_capture_options
    {
        public static Stripe.StripeChargeCaptureOptions  DestinationFee(int? destinationAmount)
        {
            return new StripeChargeCaptureOptions()
            {
                Amount = 4120,
                DestinationAmount = destinationAmount.GetValueOrDefault(),
                StatementDescriptor = "my statement"
            };
        }
    }
}
