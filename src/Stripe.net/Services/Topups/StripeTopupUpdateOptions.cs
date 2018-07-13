namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeTopupUpdateOptions : StripeBaseOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
