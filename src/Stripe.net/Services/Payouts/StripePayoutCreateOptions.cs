using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripePayoutCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// REQUIRED
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
