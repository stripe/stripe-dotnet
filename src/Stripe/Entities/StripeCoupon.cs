using System;

namespace Stripe
{
    public class StripeCoupon
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("duration")]
        public string Duration { get; set; }

        [StripeArgument("duration_in_months")]
        public int? DurationInMonths { get; set; }

        [StripeArgument("livemode")]
        public bool? LiveMode { get; set; }

        [StripeArgument("max_redemptions")]
        public int? MaxRedemptions { get; set; }

        [StripeArgument("percent_off")]
        public int? PercentOff { get; set; }
        
        [StripeArgument("redeem_by")]
        public DateTime? RedeemBy { get; set; }
    }
}
