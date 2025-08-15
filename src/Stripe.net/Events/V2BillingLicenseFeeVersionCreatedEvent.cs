// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a LicenseFeeVersion is created.
    /// </summary>
    public class V2BillingLicenseFeeVersionCreatedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.billing.license_fee_version.created event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2BillingLicenseFeeVersionCreatedEventData Data { get; set; }

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
        public Task<V2.Billing.LicenseFeeVersion> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.LicenseFeeVersion>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.LicenseFeeVersion FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.LicenseFeeVersion>(this.RelatedObject);
        }
    }
}
