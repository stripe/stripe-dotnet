// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntegrationConfigurationCheckoutSessions : StripeEntity<IntegrationConfigurationCheckoutSessions>
    {
        /// <summary>
        /// Controls the default value of automatic_tax[enabled] on new Checkout Sessions.
        /// One of: <c>disabled</c>, or <c>enabled_when_possible</c>.
        /// </summary>
        [JsonProperty("automatic_tax_default_value")]
        [STJS.JsonPropertyName("automatic_tax_default_value")]
        public string AutomaticTaxDefaultValue { get; set; }
    }
}
