// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsPayto : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsPayto>
    {
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions MandateOptions { get; set; }
    }
}
