// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
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

        /// <summary>
        /// A list of prices that the credit grant can apply to. We currently only support the
        /// <c>metered</c> prices.
        /// </summary>
        [JsonProperty("prices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prices")]
#endif
        public List<CreditBalanceSummaryFilterApplicabilityScopePriceOptions> Prices { get; set; }
    }
}
