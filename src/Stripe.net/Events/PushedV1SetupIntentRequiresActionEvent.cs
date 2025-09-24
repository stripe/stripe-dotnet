// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a SetupIntent is in requires_action state.
    /// </summary>
    public class PushedV1SetupIntentRequiresActionEvent : V2.PushedEvent
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
        public Task<SetupIntent> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<SetupIntent>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public SetupIntent FetchRelatedObject()
        {
            return this.FetchRelatedObject<SetupIntent>(this.RelatedObject);
        }

        public V1SetupIntentRequiresActionEvent Pull()
        {
            return this.PullEvent<V1SetupIntentRequiresActionEvent>();
        }

        public Task<V1SetupIntentRequiresActionEvent> PullAsync()
        {
            return this.PullEventAsync<V1SetupIntentRequiresActionEvent>();
        }
    }
}
