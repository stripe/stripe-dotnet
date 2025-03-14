// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionCreatedByOrder : StripeEntity<TransactionCreatedByOrder>
    {
        /// <summary>
        /// The Stripe Order LineItem that created this object.
        /// </summary>
        [JsonProperty("line_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item")]
#endif
        public string LineItem { get; set; }

        /// <summary>
        /// The Stripe Order that created this object.
        /// </summary>
        [JsonProperty("order")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order")]
#endif
        public string Order { get; set; }
    }
}
