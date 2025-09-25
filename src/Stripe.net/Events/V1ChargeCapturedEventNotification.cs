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
    /// Occurs whenever a previously uncaptured charge is captured.
    /// </summary>
    public class V1ChargeCapturedEventNotification : V2.EventNotification
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
        public Task<Charge> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Charge>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Charge FetchRelatedObject()
        {
            return this.FetchRelatedObject<Charge>(this.RelatedObject);
        }

        public V1ChargeCapturedEvent FetchEvent()
        {
            return this.FetchEvent<V1ChargeCapturedEvent>();
        }

        public Task<V1ChargeCapturedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1ChargeCapturedEvent>();
        }
    }
}
