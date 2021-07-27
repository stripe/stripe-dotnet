// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Number of days within which a customer must pay the invoice generated by this quote.
        /// This value will be <c>null</c> for quotes where
        /// <c>collection_method=charge_automatically</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
