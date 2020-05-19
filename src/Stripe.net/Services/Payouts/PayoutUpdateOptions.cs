namespace Stripe
{
    using Newtonsoft.Json;

    public class PayoutUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
