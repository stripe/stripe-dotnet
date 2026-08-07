// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever a balance settings status or property has changed.
    /// </summary>
    public class V1BalanceSettingsUpdatedEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<BalanceSettings> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<BalanceSettings>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public BalanceSettings FetchRelatedObject()
        {
            return this.FetchRelatedObject<BalanceSettings>(this.RelatedObject);
        }
    }
}
