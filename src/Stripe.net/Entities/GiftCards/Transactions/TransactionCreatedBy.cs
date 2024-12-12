// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionCreatedBy : StripeEntity<TransactionCreatedBy>
    {
        [JsonProperty("checkout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout")]
#endif
        public TransactionCreatedByCheckout Checkout { get; set; }

        [JsonProperty("order")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order")]
#endif
        public TransactionCreatedByOrder Order { get; set; }

        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public TransactionCreatedByPayment Payment { get; set; }

        /// <summary>
        /// The type of event that created this object.
        /// One of: <c>checkout</c>, <c>order</c>, or <c>payment</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
