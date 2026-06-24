// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an OutboundTransfer is placed under review.
    /// </summary>
    public class V2MoneyManagementOutboundTransferUnderReviewEventNotification : V2.Core.EventNotification
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
        public Task<V2.MoneyManagement.OutboundTransfer> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.OutboundTransfer>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.OutboundTransfer FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.OutboundTransfer>(this.RelatedObject);
        }

        public V2MoneyManagementOutboundTransferUnderReviewEvent FetchEvent()
        {
            return this.FetchEvent<V2MoneyManagementOutboundTransferUnderReviewEvent>();
        }

        public Task<V2MoneyManagementOutboundTransferUnderReviewEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2MoneyManagementOutboundTransferUnderReviewEvent>();
        }
    }
}
