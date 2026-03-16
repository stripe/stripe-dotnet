// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantAmountOptions : INestedOptions
    {
        /// <summary>
        /// The type of the credit grant amount. We currently support <c>monetary</c> and
        /// <c>custom_pricing_unit</c> billing credits.
        /// One of: <c>custom_pricing_unit</c>, or <c>monetary</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The custom pricing unit amount of the credit grant. Required if <c>type</c> is
        /// <c>custom_pricing_unit</c>.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public ServiceActionCreateCreditGrantAmountCustomPricingUnitOptions CustomPricingUnit { get; set; }

        /// <summary>
        /// The monetary amount of the credit grant. Required if <c>type</c> is <c>monetary</c>.
        /// </summary>
        [JsonProperty("monetary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monetary")]
#endif
        public ServiceActionCreateCreditGrantAmountMonetaryOptions Monetary { get; set; }
    }
}
