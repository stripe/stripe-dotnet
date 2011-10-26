using System;

namespace Stripe
{
    public class StripeCustomerUpdateSubscriptionOptions : CreditCardOptions
    {
        [StripeArgument("plan")]
        public string PlanId { get; set; }

        [StripeArgument("coupon")]
        public string CouponId { get; set; }

        [StripeArgument("prorate")]
        public bool? Prorate { get; set; }

        public DateTime? TrialEnd { get; set; }

        [StripeArgument("trial_end")]
        internal int? TrialEndInternal
        {
            get
            {
                if (!TrialEnd.HasValue) return null;

                var diff = TrialEnd.Value - new DateTime(1970, 1, 1);

                return (int)Math.Floor(diff.TotalSeconds);
            }
        }
    }
}
