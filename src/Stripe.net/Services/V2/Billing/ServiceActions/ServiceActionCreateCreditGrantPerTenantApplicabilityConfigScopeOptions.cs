// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateCreditGrantPerTenantApplicabilityConfigScopeOptions : INestedOptions
    {
        /// <summary>
        /// The billable items to apply the credit grant to.
        /// </summary>
        [JsonProperty("billable_items")]
        [STJS.JsonPropertyName("billable_items")]
        public List<string> BillableItems { get; set; }

        /// <summary>
        /// The price type that credit grants can apply to. We currently only support the
        /// <c>metered</c> price type. This will apply to metered prices and rate cards. Cannot be
        /// used in combination with <c>billable_items</c>.
        /// </summary>
        [JsonProperty("price_type")]
        [STJS.JsonPropertyName("price_type")]
        public string PriceType { get; set; }
    }
}
