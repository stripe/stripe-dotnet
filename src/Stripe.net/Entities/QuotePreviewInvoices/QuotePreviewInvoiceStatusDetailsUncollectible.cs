// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoiceStatusDetailsUncollectible : StripeEntity<QuotePreviewInvoiceStatusDetailsUncollectible>
    {
        /// <summary>
        /// The reason why the invoice is uncollectible.
        /// One of: <c>max_payment_attempts</c>, <c>payment_not_received</c>,
        /// <c>subscription_canceled</c>, <c>subscription_paused</c>, or <c>user_forgiven</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
