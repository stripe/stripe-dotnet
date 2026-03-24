// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ManualRuleProduct : StripeEntity<ManualRuleProduct>
    {
        /// <summary>
        /// The type of the product.
        /// One of: <c>licensed_item</c>, <c>metered_item</c>, or <c>tax_code</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The licensed item identifier.
        /// </summary>
        [JsonProperty("licensed_item")]
        [STJS.JsonPropertyName("licensed_item")]
        public string LicensedItem { get; set; }

        /// <summary>
        /// The metered item identifier.
        /// </summary>
        [JsonProperty("metered_item")]
        [STJS.JsonPropertyName("metered_item")]
        public string MeteredItem { get; set; }

        /// <summary>
        /// The tax code for the product.
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }
    }
}
