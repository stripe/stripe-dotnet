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
    /// Occurs whenever a Sigma scheduled query run finishes.
    /// </summary>
    public class V1SigmaScheduledQueryRunCreatedEventNotification : V2.EventNotification
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
        public Task<Sigma.ScheduledQueryRun> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Sigma.ScheduledQueryRun>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Sigma.ScheduledQueryRun FetchRelatedObject()
        {
            return this.FetchRelatedObject<Sigma.ScheduledQueryRun>(this.RelatedObject);
        }

        public V1SigmaScheduledQueryRunCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1SigmaScheduledQueryRunCreatedEvent>();
        }

        public Task<V1SigmaScheduledQueryRunCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1SigmaScheduledQueryRunCreatedEvent>();
        }
    }
}
