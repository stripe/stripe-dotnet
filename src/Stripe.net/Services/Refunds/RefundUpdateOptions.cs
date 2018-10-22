namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RefundUpdateOptions : BaseOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
