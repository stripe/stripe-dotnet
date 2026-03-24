// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a LicensedItem is updated.
    /// </summary>
    public class V2BillingLicensedItemUpdatedEventNotification : V2.Core.EventNotification
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


        public Task<V2.Billing.LicensedItem> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.LicensedItem>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>


        public V2.Billing.LicensedItem FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.LicensedItem>(this.RelatedObject);
        }

        public V2BillingLicensedItemUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V2BillingLicensedItemUpdatedEvent>();
        }

        public Task<V2BillingLicensedItemUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2BillingLicensedItemUpdatedEvent>();
        }
    }
}
