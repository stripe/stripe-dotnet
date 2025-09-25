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
    /// Occurs whenever a payout is <em>expected</em> to be available in the destination
    /// account. If the payout fails, a <c>payout.failed</c> notification is also sent, at a
    /// later time.
    /// </summary>
    public class V1PayoutPaidEventNotification : V2.EventNotification
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
        public Task<Payout> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Payout>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Payout FetchRelatedObject()
        {
            return this.FetchRelatedObject<Payout>(this.RelatedObject);
        }

        public V1PayoutPaidEvent FetchEvent()
        {
            return this.FetchEvent<V1PayoutPaidEvent>();
        }

        public Task<V1PayoutPaidEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PayoutPaidEvent>();
        }
    }
}
