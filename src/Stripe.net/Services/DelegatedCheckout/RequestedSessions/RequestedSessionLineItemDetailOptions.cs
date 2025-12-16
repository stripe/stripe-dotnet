// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionLineItemDetailOptions : INestedOptions
    {
        /// <summary>
        /// The key of the line item.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// The SKU ID of the line item.
        /// </summary>
        [JsonProperty("sku_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sku_id")]
#endif
        public string SkuId { get; set; }
    }
}
