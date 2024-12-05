// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsOptions : INestedOptions
    {
        /// <summary>
        /// Setting to true enables installments for this invoice. Setting to false will prevent any
        /// selected plan from applying to a payment.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this invoice.
        /// </summary>
        [JsonProperty("plan")]
        public InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions Plan { get; set; }
    }
}
