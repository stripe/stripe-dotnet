// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a top-up fails.
    /// </summary>
    public class V1TopupFailedEvent : V2.Core.Event
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
        public Task<Topup> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Topup>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Topup FetchRelatedObject()
        {
            return this.FetchRelatedObject<Topup>(this.RelatedObject);
        }
    }
}
