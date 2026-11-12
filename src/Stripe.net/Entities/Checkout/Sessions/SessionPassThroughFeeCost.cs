// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPassThroughFeeCost : StripeEntity<SessionPassThroughFeeCost>
    {
        /// <summary>
        /// The pass-through fee before tax.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// The tax on the pass-through fee. Pass-through fees aren't taxed, so this is always 0.
        /// </summary>
        [JsonProperty("amount_tax")]
        [STJS.JsonPropertyName("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// The pass-through fee after tax.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// The amount the provider calculated the fee on.
        /// </summary>
        [JsonProperty("calculation_basis_amount")]
        [STJS.JsonPropertyName("calculation_basis_amount")]
        public long CalculationBasisAmount { get; set; }
    }
}
