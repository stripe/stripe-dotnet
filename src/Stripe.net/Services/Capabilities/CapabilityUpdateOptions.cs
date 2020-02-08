namespace Stripe
{
    using Newtonsoft.Json;

    public class CapabilityUpdateOptions : BaseOptions
    {
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
