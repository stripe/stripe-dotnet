using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionCreateOptions
    {
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

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

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}