namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The number of days from which the invoice is created until it is due. Only valid for
        /// invoices where <c>billing=send_invoice</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
