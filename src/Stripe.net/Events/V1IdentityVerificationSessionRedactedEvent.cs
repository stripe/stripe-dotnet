// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a VerificationSession is redacted.
    /// </summary>
    public class V1IdentityVerificationSessionRedactedEvent : V2.Event
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
    }
}
