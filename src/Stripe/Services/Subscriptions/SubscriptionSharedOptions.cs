using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public abstract class SubscriptionSharedOptions
    {
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        // mark this obsolete and use source
        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        // do this instead of using StripeCreditCardOptions
        // [JsonProperty("source")]
        // public string SourceTokenOrExistingSourceId { get; set; }

        // [JsonProperty("source")]
        // public SourceCard SourceCard { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        public DateTime? TrialEnd { get; set; }
        public bool EndTrialNow { get; set; }

        [JsonProperty("trial_end")]
        internal string TrialEndInternal
        {
            get
            {
                if (EndTrialNow)
                    return "now";
                else if (TrialEnd.HasValue)
                    return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value).ToString();
                else
                    return null;
            }
        }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}