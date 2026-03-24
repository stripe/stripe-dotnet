// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionApplyInvoiceDiscountRule : StripeEntity<IntentActionApplyInvoiceDiscountRule>
    {
        /// <summary>
        /// The entity that the discount rule applies to, for example, the Billing Cadence.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public string AppliesTo { get; set; }

        /// <summary>
        /// The ID of the created discount rule. This is only present once the Billing Intent is
        /// committed and the discount rule is created.
        /// </summary>
        [JsonProperty("invoice_discount_rule")]
        [STJS.JsonPropertyName("invoice_discount_rule")]
        public string InvoiceDiscountRule { get; set; }

        /// <summary>
        /// Type of the discount rule.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Configuration for percentage off discount.
        /// </summary>
        [JsonProperty("percent_off")]
        [STJS.JsonPropertyName("percent_off")]
        public IntentActionApplyInvoiceDiscountRulePercentOff PercentOff { get; set; }
    }
}
