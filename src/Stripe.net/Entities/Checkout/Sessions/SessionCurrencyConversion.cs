// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCurrencyConversion : StripeEntity<SessionCurrencyConversion>
    {
        /// <summary>
        /// Total of all items in source currency before discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif

        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total of all items in source currency after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif

        public long AmountTotal { get; set; }

        /// <summary>
        /// Exchange rate used to convert source currency amounts to customer currency amounts.
        /// </summary>
        [JsonProperty("fx_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_rate")]
#endif

        public decimal FxRate { get; set; }

        /// <summary>
        /// Creation currency of the CheckoutSession before localization.
        /// </summary>
        [JsonProperty("source_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_currency")]
#endif

        public string SourceCurrency { get; set; }
    }
}
