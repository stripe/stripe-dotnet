// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountFeaturesOutboundTransfersAch : StripeEntity<FinancialAccountFeaturesOutboundTransfersAch>
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Whether the Feature is operational.
        /// One of: <c>active</c>, <c>pending</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details; includes at least one entry when the status is not <c>active</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public List<FinancialAccountFeaturesOutboundTransfersAchStatusDetail> StatusDetails { get; set; }
    }
}
