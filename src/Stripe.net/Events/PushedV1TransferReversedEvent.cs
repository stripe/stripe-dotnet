// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a transfer is reversed, including partial reversals.
    /// </summary>
    public class PushedV1TransferReversedEvent : V2.PushedEvent
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
        public Task<Transfer> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Transfer>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Transfer FetchRelatedObject()
        {
            return this.FetchRelatedObject<Transfer>(this.RelatedObject);
        }

        public V1TransferReversedEvent Pull()
        {
            return this.PullEvent<V1TransferReversedEvent>();
        }

        public Task<V1TransferReversedEvent> PullAsync()
        {
            return this.PullEventAsync<V1TransferReversedEvent>();
        }
    }
}
