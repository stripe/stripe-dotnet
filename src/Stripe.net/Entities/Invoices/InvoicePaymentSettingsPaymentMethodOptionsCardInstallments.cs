// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallments : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCardInstallments>
    {
        /// <summary>
        /// Whether Installments are enabled for this Invoice.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
