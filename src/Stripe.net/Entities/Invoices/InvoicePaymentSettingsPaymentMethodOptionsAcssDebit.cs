// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebit : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsAcssDebit>
    {
        [JsonProperty("mandate_options")]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
