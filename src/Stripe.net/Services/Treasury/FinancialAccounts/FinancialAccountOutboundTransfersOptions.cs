// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountOutboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundTransfers API.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountOutboundTransfersAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire transfers via the OutboundTransfers API.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        public FinancialAccountOutboundTransfersUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
