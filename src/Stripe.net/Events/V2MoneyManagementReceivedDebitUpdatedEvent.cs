// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This event is sent when a ReceivedDebit is updated.
    /// </summary>
    public class V2MoneyManagementReceivedDebitUpdatedEvent : V2.Event
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
        public Task<V2.ReceivedDebit> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.ReceivedDebit>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.ReceivedDebit FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.ReceivedDebit>(this.RelatedObject);
        }
    }
}
