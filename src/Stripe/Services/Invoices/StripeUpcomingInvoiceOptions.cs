using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeUpcomingInvoiceOptions
    {
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("subscription_plan")]
        public string SubscriptionPlanId { get; set; }

        [JsonProperty("subscription_prorate")]
        public bool? SubscriptionProrate { get; set; }

        public DateTime? SubscriptionProrationDate { get; set; }

        [JsonProperty("subscription_proration_date")]
        internal long? SubscriptionProrationDateInternal
        {
            get
            {
                if (!SubscriptionProrationDate.HasValue)
                    return null;

                return EpochTime.ConvertDateTimeToEpoch(SubscriptionProrationDate.Value);
            }
        }

        [JsonProperty("subscription_quantity")]
        public int? SubscriptionQuantity { get; set; }

        public DateTime? SubscriptionTrialEnd { get; set; }

        [JsonProperty("subscription_trial_end")]
        internal long? SubscriptionTrialEndInternal
        {
            get
            {
                if (!SubscriptionTrialEnd.HasValue)
                    return null;

                return EpochTime.ConvertDateTimeToEpoch(SubscriptionTrialEnd.Value);
            }
        }
    }
}
