namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateAcceptanceOptions : INestedOptions
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("notification_method")]
        public string NotificationMethod { get; set; }

        [JsonProperty("offline")]
        public SourceMandateAcceptanceOfflineOptions Offline { get; set; }

        [JsonProperty("online")]
        public SourceMandateAcceptanceOnlineOptions Online { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
