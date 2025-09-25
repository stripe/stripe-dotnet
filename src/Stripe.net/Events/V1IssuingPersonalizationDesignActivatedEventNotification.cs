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
    /// Occurs whenever a personalization design is activated following the activation of the
    /// physical bundle that belongs to it.
    /// </summary>
    public class V1IssuingPersonalizationDesignActivatedEventNotification : V2.EventNotification
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
        public Task<Issuing.PersonalizationDesign> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.PersonalizationDesign>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.PersonalizationDesign FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.PersonalizationDesign>(this.RelatedObject);
        }

        public V1IssuingPersonalizationDesignActivatedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingPersonalizationDesignActivatedEvent>();
        }

        public Task<V1IssuingPersonalizationDesignActivatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingPersonalizationDesignActivatedEvent>();
        }
    }
}
