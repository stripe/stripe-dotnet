// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a VerificationSession transitions to processing.
    /// </summary>
    public class V1IdentityVerificationSessionProcessingEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Identity.VerificationSession> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Identity.VerificationSession>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Identity.VerificationSession FetchRelatedObject()
        {
            return this.FetchRelatedObject<Identity.VerificationSession>(this.RelatedObject);
        }

        public V1IdentityVerificationSessionProcessingEvent FetchEvent()
        {
            return this.FetchEvent<V1IdentityVerificationSessionProcessingEvent>();
        }

        public Task<V1IdentityVerificationSessionProcessingEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IdentityVerificationSessionProcessingEvent>();
        }
    }
}
