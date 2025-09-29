// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever an application fee is refunded, whether from refunding a charge or from
    /// <a href="https://stripe.com/docs/api#fee_refunds">refunding the application fee
    /// directly</a>. This includes partial refunds.
    /// </summary>
    public class V1ApplicationFeeRefundedEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<ApplicationFee> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<ApplicationFee>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public ApplicationFee FetchRelatedObject()
        {
            return this.FetchRelatedObject<ApplicationFee>(this.RelatedObject);
        }
    }
}
