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
    /// Occurs whenever an authorization is created.
    /// </summary>
    public class V1IssuingAuthorizationCreatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Issuing.Authorization> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Authorization>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Authorization FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Authorization>(this.RelatedObject);
        }

        public V1IssuingAuthorizationCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingAuthorizationCreatedEvent>();
        }

        public Task<V1IssuingAuthorizationCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingAuthorizationCreatedEvent>();
        }
    }
}
