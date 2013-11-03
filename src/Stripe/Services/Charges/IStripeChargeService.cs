using System.Collections.Generic;

namespace Stripe
{
    public interface IStripeChargeService
    {
        StripeCharge Create(StripeChargeCreateOptions createOptions);
        StripeCharge Get(string chargeId);
        StripeCharge Refund(string chargeId, int? refundAmountInCents = null, bool? refundApplicationFee = null);
        IEnumerable<StripeCharge> List(int count = 10, int offset = 0, string customerId = null);
        StripeCharge Capture(string chargeId, int? captureAmountInCents = null, int? applicationFeeInCents = null);
    }
}