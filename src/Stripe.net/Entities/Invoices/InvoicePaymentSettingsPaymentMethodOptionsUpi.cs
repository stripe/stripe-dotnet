// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsUpi : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsUpi>
    {
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public InvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions MandateOptions { get; set; }
    }
}
