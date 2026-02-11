// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionRemoveOptions : INestedOptions
    {
        /// <summary>
        /// When the remove action will take effect. Defaults to on_reserve if not specified.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif
        public IntentCreateActionRemoveEffectiveAtOptions EffectiveAt { get; set; }

        /// <summary>
        /// Type of the remove action.
        /// One of: <c>invoice_discount_rule</c>, or <c>spend_modifier_rule</c>.
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

        /// <summary>
        /// The ID of the spend modifier rule to remove.
        /// </summary>
        [JsonProperty("spend_modifier_rule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_modifier_rule")]
#endif
        public string SpendModifierRule { get; set; }
    }
}
