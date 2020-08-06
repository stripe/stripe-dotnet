namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseInvoiceSettingsOptions : INestedOptions
    {
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
