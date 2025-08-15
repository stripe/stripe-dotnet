// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Event that is emitted every time an Outbound Transfer is updated.
    /// </summary>
    public class PushedV2MoneyManagementOutboundTransferUpdatedEvent : V2.PushedEvent
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

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

        public V2MoneyManagementOutboundTransferUpdatedEvent Pull()
        {
            return this.PullEvent<V2MoneyManagementOutboundTransferUpdatedEvent>();
        }

        public Task<V2MoneyManagementOutboundTransferUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V2MoneyManagementOutboundTransferUpdatedEvent>();
        }
    }
}
