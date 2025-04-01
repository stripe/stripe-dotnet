// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The generated account link has been completed.
    /// </summary>
    public class V2CoreAccountLinkCompletedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.account_link.completed event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreAccountLinkCompletedEventData Data { get; set; }

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
        public Task<V2.Core.AccountLink> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Core.AccountLink>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Core.AccountLink FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Core.AccountLink>(this.RelatedObject);
        }
    }
}
