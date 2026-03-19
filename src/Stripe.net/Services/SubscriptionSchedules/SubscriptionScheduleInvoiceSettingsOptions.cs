namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SubscriptionScheduleInvoiceSettingsOptions : INestedOptions
    {
        [JsonProperty("days_until_due")]
        [STJS.JsonPropertyName("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
