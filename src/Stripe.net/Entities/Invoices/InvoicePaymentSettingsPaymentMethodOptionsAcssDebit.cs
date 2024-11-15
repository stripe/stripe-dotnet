// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebit : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsAcssDebit>
    {
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif

        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_method")]
#endif

        public string VerificationMethod { get; set; }
    }
}
