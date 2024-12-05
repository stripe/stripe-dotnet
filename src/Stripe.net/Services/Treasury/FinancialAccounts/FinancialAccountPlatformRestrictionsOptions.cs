// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountPlatformRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Restricts all inbound money movement.
        /// One of: <c>restricted</c>, or <c>unrestricted</c>.
        /// </summary>
        [JsonProperty("inbound_flows")]
        public string InboundFlows { get; set; }

        /// <summary>
        /// Restricts all outbound money movement.
        /// One of: <c>restricted</c>, or <c>unrestricted</c>.
        /// </summary>
        [JsonProperty("outbound_flows")]
        public string OutboundFlows { get; set; }
    }
}
