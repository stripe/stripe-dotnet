namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderPayOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
