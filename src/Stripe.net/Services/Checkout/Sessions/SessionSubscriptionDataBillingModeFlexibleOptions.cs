// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionSubscriptionDataBillingModeFlexibleOptions : INestedOptions
    {
        /// <summary>
        /// Controls how invoices and invoice items display proration amounts and discount amounts.
        /// One of: <c>included</c>, or <c>itemized</c>.
        /// </summary>
        [JsonProperty("proration_discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_discounts")]
#endif
        public string ProrationDiscounts { get; set; }
    }
}
