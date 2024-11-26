// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesOutboundPaymentsUsDomesticWire : StripeEntity<FinancialAccountFeaturesOutboundPaymentsUsDomesticWire>
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public bool Requested { get; set; }

        /// <summary>
        /// Whether the Feature is operational.
        /// One of: <c>active</c>, <c>pending</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Additional details; includes at least one entry when the status is not <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public List<FinancialAccountFeaturesOutboundPaymentsUsDomesticWireStatusDetail> StatusDetails { get; set; }
    }
}
