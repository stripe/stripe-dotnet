using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeCreateOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("source")]
        public string SourceTokenOrExistingSourceId { get; set; }

        [JsonProperty("source")]
        public SourceCard SourceCard { get; set; }

        [Obsolete("This is going away in Stripe.net 7.0")]
        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("capture")]
        public bool? Capture { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        [JsonProperty("shipping")]
        public Dictionary<string, string> Shipping { get; set; }
    }
}