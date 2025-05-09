// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesOutboundPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundPayments API.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif
        public FinancialAccountFeaturesOutboundPaymentsAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire transfers via the OutboundPayments API.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_domestic_wire")]
#endif
        public FinancialAccountFeaturesOutboundPaymentsUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
