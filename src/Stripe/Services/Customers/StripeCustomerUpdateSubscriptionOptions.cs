using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCustomerUpdateSubscriptionOptions : CreditCardOptions
    {
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
