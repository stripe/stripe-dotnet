using System;

namespace Stripe
{
    public class StripeCouponCreateOptions
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("percent_off")]
        public int? PercentOff { get; set; }

        [StripeArgument("duration")]
        public string Duration { get; set; }

        [StripeArgument("duration_in_months")]
        public int? DurationInMonths { get; set; }

        [StripeArgument("max_redemptions")]
        public int? MaxRedemptions { get; set; }

        public DateTime? RedeemBy { get; set; }

        [StripeArgument("redeem_by")]
        internal int? RedeemByInternal
        {
            get
            {
                if (!RedeemBy.HasValue) return null;

                var diff = RedeemBy.Value - new DateTime(1970, 1, 1);

                return (int)Math.Floor(diff.TotalSeconds);
            }
        }
    }
}
