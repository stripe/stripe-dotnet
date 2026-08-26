// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionAutomaticTaxEnablementDetailsIntegrationConfigurationDisabledReason : StripeEntity<SessionAutomaticTaxEnablementDetailsIntegrationConfigurationDisabledReason>
    {
        /// <summary>
        /// The parameter that prevented <c>automatic_tax</c> from being enabled (e.g.
        /// <c>line_items[][tax_rates]</c>).
        /// </summary>
        [JsonProperty("conflicting_field")]
        [STJS.JsonPropertyName("conflicting_field")]
        public string ConflictingField { get; set; }
    }
}
