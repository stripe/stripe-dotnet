// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionApplyOptions : INestedOptions
    {
        /// <summary>
        /// Details for applying a discount.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public IntentCreateActionApplyDiscountOptions Discount { get; set; }

        /// <summary>
        /// When the apply action takes effect. If not specified, defaults to on_reserve.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public IntentCreateActionApplyEffectiveAtOptions EffectiveAt { get; set; }

        /// <summary>
        /// Details for applying a discount rule to future invoices.
        /// </summary>
        [JsonProperty("invoice_discount_rule")]
        [STJS.JsonPropertyName("invoice_discount_rule")]
        public IntentCreateActionApplyInvoiceDiscountRuleOptions InvoiceDiscountRule { get; set; }

        /// <summary>
        /// Details for applying a spend modifier rule. Only present if type is spend_modifier_rule.
        /// </summary>
        [JsonProperty("spend_modifier_rule")]
        [STJS.JsonPropertyName("spend_modifier_rule")]
        public IntentCreateActionApplySpendModifierRuleOptions SpendModifierRule { get; set; }

        /// <summary>
        /// Type of the apply action details.
        /// One of: <c>discount</c>, <c>invoice_discount_rule</c>, or <c>spend_modifier_rule</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
