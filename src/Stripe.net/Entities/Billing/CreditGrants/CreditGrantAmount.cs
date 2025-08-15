// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditGrantAmount : StripeEntity<CreditGrantAmount>
    {
        /// <summary>
        /// The custom pricing unit amount.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public CreditGrantAmountCustomPricingUnit CustomPricingUnit { get; set; }

        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monetary")]
#endif
        public CreditGrantAmountMonetary Monetary { get; set; }

        /// <summary>
        /// The type of this amount. We currently only support <c>monetary</c> billing credits.
        /// One of: <c>custom_pricing_unit</c>, or <c>monetary</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
