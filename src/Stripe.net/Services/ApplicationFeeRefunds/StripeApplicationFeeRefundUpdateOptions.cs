using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeApplicationFeeRefundUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
