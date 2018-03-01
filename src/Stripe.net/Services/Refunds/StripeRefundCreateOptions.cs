using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRefundCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        [JsonProperty("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
