// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeAdjustmentRelatedDispute : StripeEntity<DisputeAdjustmentRelatedDispute>
    {
        /// <summary>
        /// The ID of the Dispute associated with this DisputeAdjustment. Present when <c>type</c>
        /// is <c>dispute</c>.
        /// </summary>
        [JsonProperty("dispute")]
        [STJS.JsonPropertyName("dispute")]
        public string Dispute { get; set; }

        /// <summary>
        /// The type of Dispute associated with this DisputeAdjustment.
        /// One of: <c>dispute</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
