// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a LicenseFee is updated.
    /// </summary>
    public class PushedV2BillingLicenseFeeUpdatedEvent : V2.PushedEvent
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
        public Task<V2.Billing.LicenseFee> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.LicenseFee>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.LicenseFee FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.LicenseFee>(this.RelatedObject);
        }

        public V2BillingLicenseFeeUpdatedEvent Pull()
        {
            return this.PullEvent<V2BillingLicenseFeeUpdatedEvent>();
        }

        public Task<V2BillingLicenseFeeUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V2BillingLicenseFeeUpdatedEvent>();
        }
    }
}
