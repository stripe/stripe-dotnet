// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionCreatedByCheckout : StripeEntity<TransactionCreatedByCheckout>
    {
        /// <summary>
        /// The Stripe CheckoutSession that created this object.
        /// </summary>
        [JsonProperty("checkout_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_session")]
#endif
        public string CheckoutSession { get; set; }

        /// <summary>
        /// The Stripe CheckoutSession LineItem that created this object.
        /// </summary>
        [JsonProperty("line_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item")]
#endif
        public string LineItem { get; set; }
    }
}
