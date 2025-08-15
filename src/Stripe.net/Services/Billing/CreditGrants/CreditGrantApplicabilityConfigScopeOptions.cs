// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditGrantApplicabilityConfigScopeOptions : INestedOptions
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
        public List<CreditGrantApplicabilityConfigScopeBillableItemOptions> BillableItems { get; set; }

        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type. Cannot be used in combination with <c>prices</c>.
        /// </summary>
        [JsonProperty("price_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_type")]
#endif
        public string PriceType { get; set; }

        /// <summary>
        /// A list of prices that the credit grant can apply to. We currently only support the
        /// <c>metered</c> prices. Cannot be used in combination with <c>price_type</c>.
        /// </summary>
        [JsonProperty("prices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prices")]
#endif
        public List<CreditGrantApplicabilityConfigScopePriceOptions> Prices { get; set; }
    }
}
