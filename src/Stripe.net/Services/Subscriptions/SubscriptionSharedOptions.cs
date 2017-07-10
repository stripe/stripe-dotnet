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

        [Obsolete("Use Source or SourceCard")]
        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// If you use Source as a token, you cannot use SourceCard also.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// If you use SourceCard, you cannot use Source also.
        /// </summary>
        [JsonProperty("source")]
        public SourceCard SourceCard { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        public DateTime? TrialEnd { get; set; }
        public bool EndTrialNow { get; set; }

        [JsonProperty("trial_end")]
        internal string TrialEndInternal => EndTrialNow ? "now" : TrialEnd?.ConvertDateTimeToEpoch().ToString();

        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}