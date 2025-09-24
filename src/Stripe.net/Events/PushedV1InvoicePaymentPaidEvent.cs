// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when an InvoicePayment is successfully paid.
    /// </summary>
    public class PushedV1InvoicePaymentPaidEvent : V2.PushedEvent
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
        public Task<InvoicePayment> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<InvoicePayment>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public InvoicePayment FetchRelatedObject()
        {
            return this.FetchRelatedObject<InvoicePayment>(this.RelatedObject);
        }

        public V1InvoicePaymentPaidEvent Pull()
        {
            return this.PullEvent<V1InvoicePaymentPaidEvent>();
        }

        public Task<V1InvoicePaymentPaidEvent> PullAsync()
        {
            return this.PullEventAsync<V1InvoicePaymentPaidEvent>();
        }
    }
}
