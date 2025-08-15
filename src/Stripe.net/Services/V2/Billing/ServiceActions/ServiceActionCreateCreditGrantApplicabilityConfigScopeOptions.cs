// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ServiceActionCreateCreditGrantApplicabilityConfigScopeOptions : INestedOptions
    {
        /// <summary>
        /// The billable items to apply the credit grant to.
        /// </summary>
        [JsonProperty("billable_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billable_items")]
#endif
        public List<string> BillableItems { get; set; }

        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type. This will apply to metered prices and rate cards. Cannot be
        /// used in combination with <c>billable_items</c>.
        /// </summary>
        [JsonProperty("price_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_type")]
#endif
        public string PriceType { get; set; }
    }
}
