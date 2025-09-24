// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when funds are reinstated to your account after a dispute is closed. This
    /// includes <a
    /// href="https://docs.stripe.com/disputes#disputes-on-partially-refunded-payments">partially
    /// refunded payments</a>.
    /// </summary>
    public class V1ChargeDisputeFundsReinstatedEvent : V2.Event
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
        public Task<Dispute> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Dispute>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Dispute FetchRelatedObject()
        {
            return this.FetchRelatedObject<Dispute>(this.RelatedObject);
        }
    }
}
