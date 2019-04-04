namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateAcceptanceOptions : INestedOptions
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("notification_method")]
        public string NotificationMethod { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("online")]
        public SourceMandateOnlineOptions Online { get; set; }

        [JsonProperty("offline")]
        public SourceMandateOfflineOptions Offline { get; set; }
    }
}
