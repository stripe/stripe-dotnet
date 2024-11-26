// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountPlatformRestrictions : StripeEntity<FinancialAccountPlatformRestrictions>
    {
        /// <summary>
        /// Restricts all inbound money movement.
        /// One of: <c>restricted</c>, or <c>unrestricted</c>.
        /// </summary>
        [JsonProperty("inbound_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_flows")]
#endif
        public string InboundFlows { get; set; }

        /// <summary>
        /// Restricts all outbound money movement.
        /// One of: <c>restricted</c>, or <c>unrestricted</c>.
        /// </summary>
        [JsonProperty("outbound_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_flows")]
#endif
        public string OutboundFlows { get; set; }
    }
}
