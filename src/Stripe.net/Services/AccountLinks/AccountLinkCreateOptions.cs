namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountLinkCreateOptions : BaseOptions
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("collect")]
        public string Collect { get; set; }

        [Obsolete("Use RefreshUrl instead.")]
        [JsonProperty("failure_url")]
        public string FailureUrl { get; set; }

        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [Obsolete("Use ReturnUrl instead.")]
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
