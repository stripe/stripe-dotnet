// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ManualRuleProduct : StripeEntity<ManualRuleProduct>
    {
        /// <summary>
        /// The type of the product.
        /// One of: <c>licensed_item</c>, <c>metered_item</c>, or <c>tax_code</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The licensed item identifier.
        /// </summary>
        [JsonProperty("licensed_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("licensed_item")]
#endif
        public string LicensedItem { get; set; }

        /// <summary>
        /// The metered item identifier.
        /// </summary>
        [JsonProperty("metered_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metered_item")]
#endif
        public string MeteredItem { get; set; }

        /// <summary>
        /// The tax code for the product.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }
    }
}
