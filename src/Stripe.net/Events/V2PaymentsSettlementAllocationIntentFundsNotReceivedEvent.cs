// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when SettlementAllocationIntent's <c>expected_settlement_date</c> is one day away
    /// and no matching ReceivedCredit exists.
    /// </summary>
    public class V2PaymentsSettlementAllocationIntentFundsNotReceivedEvent : V2.Core.Event
    {
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
        public Task<V2.Payments.SettlementAllocationIntent> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Payments.SettlementAllocationIntent>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Payments.SettlementAllocationIntent FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Payments.SettlementAllocationIntent>(this.RelatedObject);
        }
    }
}
