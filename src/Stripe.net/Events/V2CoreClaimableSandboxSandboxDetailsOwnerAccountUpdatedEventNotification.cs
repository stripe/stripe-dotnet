// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a claimable sandbox is activated by the user with the intention to go live
    /// and your Stripe app is installed on the live account.
    /// </summary>
    public class V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>


        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>


        public Task<V2.Core.ClaimableSandbox> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Core.ClaimableSandbox>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>


        public V2.Core.ClaimableSandbox FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Core.ClaimableSandbox>(this.RelatedObject);
        }

        public V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent>();
        }

        public Task<V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreClaimableSandboxSandboxDetailsOwnerAccountUpdatedEvent>();
        }
    }
}
