// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionAutomaticTaxEnablementDetails : StripeEntity<SessionAutomaticTaxEnablementDetails>
    {
        /// <summary>
        /// Present when <c>source=tax_integration_configuration</c> and
        /// <c>automatic_tax[enabled]=false</c>.
        /// </summary>
        [JsonProperty("integration_configuration_disabled_reason")]
        [STJS.JsonPropertyName("integration_configuration_disabled_reason")]
        public SessionAutomaticTaxEnablementDetailsIntegrationConfigurationDisabledReason IntegrationConfigurationDisabledReason { get; set; }

        /// <summary>
        /// How <c>automatic_tax</c> was set: <c>explicit</c>, <c>managed_payments</c>, or
        /// <c>tax_integration_configuration</c>.
        /// One of: <c>explicit</c>, <c>managed_payments</c>, or
        /// <c>tax_integration_configuration</c>.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
