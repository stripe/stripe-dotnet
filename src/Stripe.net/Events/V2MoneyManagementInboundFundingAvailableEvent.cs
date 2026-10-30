// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when the funds for an InboundFunding become available.
    /// </summary>
    public class V2MoneyManagementInboundFundingAvailableEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.money_management.inbound_funding.available event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public V2MoneyManagementInboundFundingAvailableEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.MoneyManagement.InboundFunding> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.InboundFunding>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.InboundFunding FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.InboundFunding>(this.RelatedObject);
        }
    }
}
