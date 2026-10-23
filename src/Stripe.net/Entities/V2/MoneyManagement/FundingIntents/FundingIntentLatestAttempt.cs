// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentLatestAttempt : StripeEntity<FundingIntentLatestAttempt>
    {
        /// <summary>
        /// The ID of the InboundFunding created by the attempt.
        /// </summary>
        [JsonProperty("inbound_funding")]
        [STJS.JsonPropertyName("inbound_funding")]
        public string InboundFunding { get; set; }

        /// <summary>
        /// The type of underlying money movement created by the attempt.
        /// One of: <c>inbound_funding</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
