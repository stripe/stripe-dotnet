namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
