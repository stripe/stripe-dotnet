// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountFeaturesOutboundPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundPayments API.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public FinancialAccountFeaturesOutboundPaymentsAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire transfers via the OutboundPayments API.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        [STJS.JsonPropertyName("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundPaymentsUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
