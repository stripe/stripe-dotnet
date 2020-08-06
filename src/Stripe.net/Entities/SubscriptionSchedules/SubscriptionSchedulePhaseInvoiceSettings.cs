namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseInvoiceSettings : StripeEntity<SubscriptionSchedulePhaseInvoiceSettings>
    {
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
