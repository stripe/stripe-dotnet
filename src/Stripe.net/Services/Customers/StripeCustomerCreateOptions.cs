using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCustomerCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("shipping")]
        public StripeShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public SourceCard SourceCard { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }

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
                else if (TrialEnd.HasValue)
                    return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value).ToString();
                else
                    return null;
            }
        }

        #endregion
    }
}
