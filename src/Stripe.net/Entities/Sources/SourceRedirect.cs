namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceRedirect : StripeEntity<SourceRedirect>
    {
        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
