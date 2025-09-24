// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever an early fraud warning is created.
    /// </summary>
    public class PushedV1RadarEarlyFraudWarningCreatedEvent : V2.PushedEvent
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
        public Task<Radar.EarlyFraudWarning> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Radar.EarlyFraudWarning>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Radar.EarlyFraudWarning FetchRelatedObject()
        {
            return this.FetchRelatedObject<Radar.EarlyFraudWarning>(this.RelatedObject);
        }

        public V1RadarEarlyFraudWarningCreatedEvent Pull()
        {
            return this.PullEvent<V1RadarEarlyFraudWarningCreatedEvent>();
        }

        public Task<V1RadarEarlyFraudWarningCreatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1RadarEarlyFraudWarningCreatedEvent>();
        }
    }
}
