// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditBalanceSummaryFilterApplicabilityScopeOptions : INestedOptions
    {
        /// <summary>
        /// A list of billable items that the credit grant can apply to. We currently only support
        /// metered billable items. Cannot be used in combination with <c>price_type</c> or
        /// <c>prices</c>.
        /// </summary>
        [JsonProperty("billable_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billable_items")]
#endif
        public List<CreditBalanceSummaryFilterApplicabilityScopeBillableItemOptions> BillableItems { get; set; }

        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type. Cannot be used in combination with <c>prices</c>.
        /// </summary>
        [JsonProperty("price_type")]
        [STJS.JsonPropertyName("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// A list of prices that the credit grant can apply to. We currently only support the
        /// <c>metered</c> prices. Cannot be used in combination with <c>price_type</c>.
        /// </summary>
        [JsonProperty("prices")]
        [STJS.JsonPropertyName("prices")]
        public List<CreditBalanceSummaryFilterApplicabilityScopePriceOptions> Prices { get; set; }
    }
}
