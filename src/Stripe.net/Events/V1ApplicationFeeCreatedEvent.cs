// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever an application fee is created on a charge.
    /// </summary>
    public class V1ApplicationFeeCreatedEvent : V2.Event
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
        public Task<ApplicationFee> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<ApplicationFee>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public ApplicationFee FetchRelatedObject()
        {
            return this.FetchRelatedObject<ApplicationFee>(this.RelatedObject);
        }
    }
}
