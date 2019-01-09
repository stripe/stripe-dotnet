namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountLinkCreateOptions : BaseOptions
    {
        [JsonProperty("account")]
        public string AccountId { get; set; }

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
