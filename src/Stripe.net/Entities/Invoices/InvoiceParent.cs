// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceParent : StripeEntity<InvoiceParent>
    {
        /// <summary>
        /// Details about the quote that generated this invoice.
        /// </summary>
        [JsonProperty("quote_details")]
        [STJS.JsonPropertyName("quote_details")]
        public InvoiceParentQuoteDetails QuoteDetails { get; set; }

        /// <summary>
        /// Details about the subscription that generated this invoice.
        /// </summary>
        [JsonProperty("subscription_details")]
        [STJS.JsonPropertyName("subscription_details")]
        public InvoiceParentSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this invoice.
        /// One of: <c>quote_details</c>, or <c>subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
