// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionRemove : StripeEntity<IntentActionRemove>
    {
        /// <summary>
        /// When the remove action will take effect. If not specified, defaults to on_reserve.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public IntentActionRemoveEffectiveAt EffectiveAt { get; set; }

        /// <summary>
        /// Type of the remove action.
        /// One of: <c>invoice_discount_rule</c>, or <c>spend_modifier_rule</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the discount rule to remove for future invoices.
        /// </summary>
        [JsonProperty("invoice_discount_rule")]
        [STJS.JsonPropertyName("invoice_discount_rule")]
        public string InvoiceDiscountRule { get; set; }

        /// <summary>
        /// The ID of the spend modifier rule removed.
        /// </summary>
        [JsonProperty("spend_modifier_rule")]
        [STJS.JsonPropertyName("spend_modifier_rule")]
        public string SpendModifierRule { get; set; }
    }
}
