// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a dispute is updated.
    /// </summary>
    public class V1IssuingDisputeUpdatedEvent : V2.Core.Event
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
        public Task<Issuing.Dispute> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Dispute>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Dispute FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Dispute>(this.RelatedObject);
        }
    }
}
