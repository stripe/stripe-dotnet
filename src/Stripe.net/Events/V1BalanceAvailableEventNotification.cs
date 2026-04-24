// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever your Stripe balance has been updated (e.g., when a charge is available
    /// to be paid out). By default, Stripe automatically transfers funds in your balance to
    /// your bank account on a daily basis. This event is not fired for negative transactions.
    /// </summary>
    public class V1BalanceAvailableEventNotification : V2.Core.EventNotification
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
        public Task<Balance> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Balance>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Balance FetchRelatedObject()
        {
            return this.FetchRelatedObject<Balance>(this.RelatedObject);
        }

        public V1BalanceAvailableEvent FetchEvent()
        {
            return this.FetchEvent<V1BalanceAvailableEvent>();
        }

        public Task<V1BalanceAvailableEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BalanceAvailableEvent>();
        }
    }
}
