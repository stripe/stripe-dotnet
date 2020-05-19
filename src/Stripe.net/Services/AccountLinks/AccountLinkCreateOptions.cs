namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountLinkCreateOptions : BaseOptions
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("collect")]
        public string Collect { get; set; }

        [JsonProperty("failure_url")]
        public string FailureUrl { get; set; }

        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
