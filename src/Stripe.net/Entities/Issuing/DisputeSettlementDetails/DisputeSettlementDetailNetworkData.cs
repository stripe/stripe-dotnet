// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeSettlementDetailNetworkData : StripeEntity<DisputeSettlementDetailNetworkData>
    {
        /// <summary>
        /// The date the transaction was processed by the card network. This can be different from
        /// the date the seller recorded the transaction depending on when the acquirer submits the
        /// transaction to the network.
        /// </summary>
        [JsonProperty("processing_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("processing_date")]
#endif
        public string ProcessingDate { get; set; }
    }
}
