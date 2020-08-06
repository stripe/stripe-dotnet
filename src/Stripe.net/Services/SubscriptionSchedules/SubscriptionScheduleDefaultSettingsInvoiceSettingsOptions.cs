namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions : INestedOptions
    {
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
