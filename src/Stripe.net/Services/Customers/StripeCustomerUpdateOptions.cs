using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCustomerUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public SourceCard SourceCard { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("shipping")]
        public StripeShippingOptions Shipping { get; set; }
    }
}
