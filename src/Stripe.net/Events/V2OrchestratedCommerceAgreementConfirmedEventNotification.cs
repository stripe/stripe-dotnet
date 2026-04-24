// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when an Agreement is confirmed by one party.
    /// </summary>
    public class V2OrchestratedCommerceAgreementConfirmedEventNotification : V2.Core.EventNotification
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

        public V2OrchestratedCommerceAgreementConfirmedEvent FetchEvent()
        {
            return this.FetchEvent<V2OrchestratedCommerceAgreementConfirmedEvent>();
        }

        public Task<V2OrchestratedCommerceAgreementConfirmedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2OrchestratedCommerceAgreementConfirmedEvent>();
        }
    }
}
