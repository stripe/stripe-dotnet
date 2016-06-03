using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoiceUpdateOptions
    {
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        [JsonProperty("closed")]
        public bool? Closed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("forgiven")]
        public bool? Forgiven { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        #region Trial End

        public DateTime? TrialEnd { get; set; }

        public bool EndTrialNow { get; set; }

        [JsonProperty("trial_end")]
        internal string TrialEndInternal
        {
            get
            {
                if (EndTrialNow)
                    return "now";
                if (TrialEnd.HasValue)
                    return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value).ToString();
                return null;
            }
        }

        #endregion

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
