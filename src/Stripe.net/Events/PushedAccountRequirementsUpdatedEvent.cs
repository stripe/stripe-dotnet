// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an Account's requirements are updated.
    /// </summary>
    public class PushedAccountRequirementsUpdatedEvent : V2.PushedEvent
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
        public Task<V2.Account> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Account>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Account FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Account>(this.RelatedObject);
        }

        public AccountRequirementsUpdatedEvent Pull()
        {
            return this.PullEvent<AccountRequirementsUpdatedEvent>();
        }

        public Task<AccountRequirementsUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<AccountRequirementsUpdatedEvent>();
        }
    }
}
