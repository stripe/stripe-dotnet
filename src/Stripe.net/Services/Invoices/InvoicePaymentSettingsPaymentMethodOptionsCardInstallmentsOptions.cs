// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this invoice. Setting to false will prevent any
        /// selected plan from applying to a payment.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this invoice.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif

        public InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
