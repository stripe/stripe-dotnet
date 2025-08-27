// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionRemove : StripeEntity<IntentActionRemove>
    {
        /// <summary>
        /// Type of the remove action.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The ID of the discount rule to remove for future invoices.
        /// </summary>
        [JsonProperty("invoice_discount_rule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_discount_rule")]
#endif
        public string InvoiceDiscountRule { get; set; }
    }
}
