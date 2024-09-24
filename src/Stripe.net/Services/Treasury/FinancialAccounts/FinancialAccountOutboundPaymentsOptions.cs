namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesOutboundPaymentsOptions instead.")]
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
