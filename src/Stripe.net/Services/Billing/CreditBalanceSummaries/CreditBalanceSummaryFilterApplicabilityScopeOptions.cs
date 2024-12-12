// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditBalanceSummaryFilterApplicabilityScopeOptions : INestedOptions
    {
        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type.
        /// </summary>
        [JsonProperty("price_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_type")]
#endif
        public string PriceType { get; set; }
    }
}
