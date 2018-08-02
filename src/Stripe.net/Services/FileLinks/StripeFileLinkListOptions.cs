namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeFileLinkListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }
}
