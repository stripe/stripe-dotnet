// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionApply : StripeEntity<IntentActionApply>
    {
        /// <summary>
        /// Type of the apply action details.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Details for applying a discount rule to future invoices.
        /// </summary>
        [JsonProperty("invoice_discount_rule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_discount_rule")]
#endif
        public IntentActionApplyInvoiceDiscountRule InvoiceDiscountRule { get; set; }
    }
}
