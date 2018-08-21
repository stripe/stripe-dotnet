namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateOptions : INestedOptions
    {
        [JsonProperty("acceptance[date]")]
        public DateTime? MandateAcceptanceDate { get; set; }

        [JsonProperty("acceptance[ip]")]
        public string MandateAcceptanceIp { get; set; }

        [JsonProperty("acceptance[status]")]
        public string MandateAcceptanceStatus { get; set; }

        [JsonProperty("acceptance[user_agent]")]
        public string MandateAcceptanceUserAgent { get; set; }

        [JsonProperty("notification_method")]
        public string MandateNotificationMethod { get; set; }
    }
}
