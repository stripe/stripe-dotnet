// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an Agreement is partially confirmed (confirmed by one party but not both).
    /// </summary>
    public class V2OrchestratedCommerceAgreementPartiallyConfirmedEventNotification : V2.Core.EventNotification
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
        public Task<V2.OrchestratedCommerce.Agreement> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.OrchestratedCommerce.Agreement>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.OrchestratedCommerce.Agreement FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.OrchestratedCommerce.Agreement>(this.RelatedObject);
        }

        public V2OrchestratedCommerceAgreementPartiallyConfirmedEvent FetchEvent()
        {
            return this.FetchEvent<V2OrchestratedCommerceAgreementPartiallyConfirmedEvent>();
        }

        public Task<V2OrchestratedCommerceAgreementPartiallyConfirmedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2OrchestratedCommerceAgreementPartiallyConfirmedEvent>();
        }
    }
}
