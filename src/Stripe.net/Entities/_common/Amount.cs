namespace Stripe.V2
{
    using Newtonsoft.Json;

    public class Amount
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}