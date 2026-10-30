// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an InboundFunding transitions into the succeeded state.
    /// </summary>
    public class V2MoneyManagementInboundFundingCheckSucceededEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]
        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V2MoneyManagementInboundFundingCheckSucceededEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementInboundFundingCheckSucceededEvent>();
        }

        public Task<V2MoneyManagementInboundFundingCheckSucceededEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementInboundFundingCheckSucceededEvent>();
        }
    }
}
