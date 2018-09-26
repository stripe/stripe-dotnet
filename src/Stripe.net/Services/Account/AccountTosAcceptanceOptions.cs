namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountTosAcceptanceOptions : INestedOptions
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
