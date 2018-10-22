namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CouponUpdateOptions : BaseOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
