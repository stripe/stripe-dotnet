// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a settlement allocation intent split is settled.
    /// </summary>
    public class V2PaymentsSettlementAllocationIntentSplitSettledEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.payments.settlement_allocation_intent_split.settled event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2PaymentsSettlementAllocationIntentSplitSettledEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.Payments.SettlementAllocationIntentSplit> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Payments.SettlementAllocationIntentSplit>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Payments.SettlementAllocationIntentSplit FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Payments.SettlementAllocationIntentSplit>(this.RelatedObject);
        }
    }
}
