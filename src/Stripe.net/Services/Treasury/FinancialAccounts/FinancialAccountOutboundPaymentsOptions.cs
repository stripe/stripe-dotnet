// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountOutboundPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH transfers via the OutboundPayments API.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountOutboundPaymentsAchOptions Ach { get; set; }

        /// <summary>
        /// Enables US domestic wire transfers via the OutboundPayments API.
        /// </summary>
        [JsonProperty("us_domestic_wire")]
        public FinancialAccountOutboundPaymentsUsDomesticWireOptions UsDomesticWire { get; set; }
    }
}
