// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a dispute is closed and the dispute status changes to <c>lost</c>,
    /// <c>warning_closed</c>, or <c>won</c>.
    /// </summary>
    public class V1ChargeDisputeClosedEvent : V2.Core.Event
    {
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
        public Task<Dispute> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Dispute>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Dispute FetchRelatedObject()
        {
            return this.FetchRelatedObject<Dispute>(this.RelatedObject);
        }
    }
}
