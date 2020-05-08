namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class DisputeUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
