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
        /// When the apply action will take effect. Defaults to on_reserve if not specified.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public IntentActionApplyEffectiveAt EffectiveAt { get; set; }

        /// <summary>
        /// Type of the apply action details.
        /// One of: <c>invoice_discount_rule</c>, or <c>spend_modifier_rule</c>.
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

        /// <summary>
        /// Details for applying a spend modifier rule. Only present if type is spend_modifier_rule.
        /// </summary>
        [JsonProperty("spend_modifier_rule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_modifier_rule")]
#endif
        public IntentActionApplySpendModifierRule SpendModifierRule { get; set; }
    }
}
