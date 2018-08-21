namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ApplicationFeeRefundCreateOptions : BaseOptions, ISupportMetadata
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
