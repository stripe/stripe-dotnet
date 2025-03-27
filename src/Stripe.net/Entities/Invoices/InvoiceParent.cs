// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceParent : StripeEntity<InvoiceParent>
    {
        [JsonProperty("quote_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quote_details")]
#endif
        public InvoiceParentQuoteDetails QuoteDetails { get; set; }

        [JsonProperty("subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_details")]
#endif
        public InvoiceParentSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// One of: <c>quote_details</c>, or <c>subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
