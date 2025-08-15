// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an InboundTransfer starts processing.
    /// </summary>
    public class PushedV2MoneyManagementInboundTransferBankDebitProcessingEvent : V2.PushedEvent
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
        public Task<V2.MoneyManagement.InboundTransfer> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.MoneyManagement.InboundTransfer>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.MoneyManagement.InboundTransfer FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.MoneyManagement.InboundTransfer>(this.RelatedObject);
        }

        public V2MoneyManagementInboundTransferBankDebitProcessingEvent Pull()
        {
            return this.PullEvent<V2MoneyManagementInboundTransferBankDebitProcessingEvent>();
        }

        public Task<V2MoneyManagementInboundTransferBankDebitProcessingEvent> PullAsync()
        {
            return this.PullEventAsync<V2MoneyManagementInboundTransferBankDebitProcessingEvent>();
        }
    }
}
