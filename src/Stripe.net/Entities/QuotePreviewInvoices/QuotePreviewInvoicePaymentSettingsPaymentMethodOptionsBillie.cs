// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsBillie : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsBillie>
    {
        [JsonProperty("company_details")]
        [STJS.JsonPropertyName("company_details")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails CompanyDetails { get; set; }

        /// <summary>
        /// An identifier or reference that this payment corresponds to.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
