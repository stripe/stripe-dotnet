namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleInvoiceSettingsOptions : INestedOptions
    {
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
