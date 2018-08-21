namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardSharedOptions : BaseOptions, ISupportMetadata
    {
        [JsonProperty("billing")]
        public BillingOptions Billing { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
