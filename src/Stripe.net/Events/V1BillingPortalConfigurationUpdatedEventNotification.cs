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
    /// Occurs whenever a portal configuration is updated.
    /// </summary>
    public class V1BillingPortalConfigurationUpdatedEventNotification : V2.Core.EventNotification
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
        public Task<BillingPortal.Configuration> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<BillingPortal.Configuration>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public BillingPortal.Configuration FetchRelatedObject()
        {
            return this.FetchRelatedObject<BillingPortal.Configuration>(this.RelatedObject);
        }

        public V1BillingPortalConfigurationUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingPortalConfigurationUpdatedEvent>();
        }

        public Task<V1BillingPortalConfigurationUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingPortalConfigurationUpdatedEvent>();
        }
    }
}
