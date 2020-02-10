namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionPendingUpdate : StripeEntity<SubscriptionPendingUpdate>
    {
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? BillingCycleAnchor { get; set; }

        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("subscription_items")]
        public List<SubscriptionItem> SubscriptionItems { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }
    }
}
