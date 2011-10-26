using System;

namespace Stripe
{
    public class StripeCustomerCreateOptions : CreditCardOptions
    {
        [StripeArgument("coupon")]
        public string CouponId { get; set; }

        [StripeArgument("email")]
        public string Email { get; set; }

        [StripeArgument("description")]
        public string Description { get; set; }

        [StripeArgument("plan")]
        public string PlanId { get; set; }

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
