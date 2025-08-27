// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionApplyInvoiceDiscountRule : StripeEntity<IntentActionApplyInvoiceDiscountRule>
    {
        /// <summary>
        /// The entity that the discount rule applies to, for example, the Billing Cadence.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public string AppliesTo { get; set; }

        /// <summary>
        /// The ID of the created discount rule. This is only present once the Billing Intent is
        /// committed and the discount rule is created.
        /// </summary>
        [JsonProperty("invoice_discount_rule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_discount_rule")]
#endif
        public string InvoiceDiscountRule { get; set; }

        /// <summary>
        /// Type of the discount rule.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Configuration for percentage off discount.
        /// </summary>
        [JsonProperty("percent_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_off")]
#endif
        public IntentActionApplyInvoiceDiscountRulePercentOff PercentOff { get; set; }
    }
}
