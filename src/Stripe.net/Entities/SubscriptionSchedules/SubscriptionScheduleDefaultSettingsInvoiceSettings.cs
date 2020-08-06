namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsInvoiceSettings : StripeEntity<SubscriptionScheduleDefaultSettingsInvoiceSettings>
    {
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
