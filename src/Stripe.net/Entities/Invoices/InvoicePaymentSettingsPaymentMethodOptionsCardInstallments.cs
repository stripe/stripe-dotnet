// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallments : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Whether Installments are enabled for this Invoice.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }
    }
}
