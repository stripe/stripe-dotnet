namespace Stripe
{
    using Newtonsoft.Json;

    public class TransferUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
