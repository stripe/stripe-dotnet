using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_charge_capture_options
    {
        public static Stripe.StripeChargeCaptureOptions  DestinationFee(string destinationAccountId, int? destinationAmount)
        {
            return new StripeChargeCaptureOptions()
            {
                Amount = 675309,
                Destination = destinationAccountId,
                DestinationAmount = destinationAmount.GetValueOrDefault(),
                StatementDescriptor = "my statement"
            };
        }
    }
}
