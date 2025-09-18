// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleBillingModeFlexibleOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to display gross amounts, net amounts, and discount amounts
        /// consistently between prorations and non-proration items on invoices, line items, and
        /// invoice items. Once set to <c>true</c>, you can't change it back to <c>false</c>.
        /// </summary>
        [JsonProperty("consistent_proration_discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("consistent_proration_discount_amounts")]
#endif
        public bool? ConsistentProrationDiscountAmounts { get; set; }
    }
}
