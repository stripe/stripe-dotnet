// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteInvoiceSettings : StripeEntity<QuoteInvoiceSettings>
    {
        /// <summary>
        /// Number of days within which a customer must pay invoices generated by this quote. This
        /// value will be <c>null</c> for quotes where
        /// <c>collection_method=charge_automatically</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("days_until_due")]
#endif
        public long? DaysUntilDue { get; set; }

        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public QuoteInvoiceSettingsIssuer Issuer { get; set; }
    }
}
