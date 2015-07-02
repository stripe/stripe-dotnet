using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCustomerCreateOptions
    {
        [JsonProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_end")]
        internal long? TrialEndInternal
        {
            get
            {
                if (!TrialEnd.HasValue) return null;

                return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value);
            }
        }
    }
}
