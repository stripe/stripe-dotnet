// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditGrantApplicabilityConfigScope : StripeEntity<CreditGrantApplicabilityConfigScope>
    {
        /// <summary>
        /// The billable items that credit grants can apply to. We currently only support metered
        /// billable items. Cannot be used in combination with <c>price_type</c> or <c>prices</c>.
        /// </summary>
        [JsonProperty("billable_items")]
        [STJS.JsonPropertyName("billable_items")]
        public List<CreditGrantApplicabilityConfigScopeBillableItem> BillableItems { get; set; }

        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type. This refers to prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
        /// Cannot be used in combination with <c>prices</c>.
        /// </summary>
        [JsonProperty("price_type")]
        [STJS.JsonPropertyName("price_type")]
        public string PriceType { get; set; }

        /// <summary>
        /// The prices that credit grants can apply to. We currently only support <c>metered</c>
        /// prices. This refers to prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
        /// Cannot be used in combination with <c>price_type</c>.
        /// </summary>
        [JsonProperty("prices")]
        [STJS.JsonPropertyName("prices")]
        public List<CreditGrantApplicabilityConfigScopePrice> Prices { get; set; }
    }
}
