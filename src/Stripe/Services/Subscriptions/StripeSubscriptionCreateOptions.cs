using System;

using Newtonsoft.Json;

namespace Stripe.Services.Subscriptions
{
    public class StripeSubscriptionCreateOptions : CreditCardOptions
    {
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        public DateTime? TrialEnd { get; set; }
        public bool EndTrialNow { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("trial_end")]
        internal string TrialEndInternal
        {
            get
            {
                if (!TrialEnd.HasValue) return null;

                var diff = TrialEnd.Value - new DateTime(1970, 1, 1);

                if (EndTrialNow)
                    return "now";
                else
                    return Math.Floor(diff.TotalSeconds).ToString();
            }
        }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFee { get; set; }
    }
}