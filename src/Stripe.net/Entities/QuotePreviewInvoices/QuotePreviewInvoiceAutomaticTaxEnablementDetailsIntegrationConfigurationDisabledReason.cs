// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoiceAutomaticTaxEnablementDetailsIntegrationConfigurationDisabledReason : StripeEntity<QuotePreviewInvoiceAutomaticTaxEnablementDetailsIntegrationConfigurationDisabledReason>
    {
        /// <summary>
        /// The parameter that prevented <c>automatic_tax</c> from being enabled (for example
        /// <c>default_tax_rates</c>).
        /// </summary>
        [JsonProperty("conflicting_field")]
        [STJS.JsonPropertyName("conflicting_field")]
        public string ConflictingField { get; set; }
    }
}
