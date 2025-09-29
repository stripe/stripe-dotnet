// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a Sigma scheduled query run finishes.
    /// </summary>
    public class V1SigmaScheduledQueryRunCreatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
