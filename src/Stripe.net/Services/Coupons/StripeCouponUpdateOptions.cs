namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeCouponUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
