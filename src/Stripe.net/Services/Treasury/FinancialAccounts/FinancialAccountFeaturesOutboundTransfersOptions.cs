// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountFeaturesOutboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundTransfers API.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountFeaturesOutboundTransfersAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire transfers via the OutboundTransfers API.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        public FinancialAccountFeaturesOutboundTransfersUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
