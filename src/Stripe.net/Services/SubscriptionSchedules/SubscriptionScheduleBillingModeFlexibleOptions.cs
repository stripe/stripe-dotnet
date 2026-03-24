// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleBillingModeFlexibleOptions : INestedOptions
    {
        /// <summary>
        /// Controls how invoices and invoice items display proration amounts and discount amounts.
        /// One of: <c>included</c>, or <c>itemized</c>.
        /// </summary>
        [JsonProperty("proration_discounts")]
        [STJS.JsonPropertyName("proration_discounts")]
        public string ProrationDiscounts { get; set; }
    }
}
