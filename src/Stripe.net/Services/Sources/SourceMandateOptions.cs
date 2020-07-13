namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateOptions : INestedOptions
    {
        [JsonProperty("acceptance")]
        public SourceMandateAcceptanceOptions Acceptance { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("notification_method")]
        public string NotificationMethod { get; set; }
    }
}
