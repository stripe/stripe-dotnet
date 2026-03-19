// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrencyConversion : StripeEntity<SessionCurrencyConversion>
    {
        /// <summary>
        /// Total of all items in source currency before discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total of all items in source currency after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// Exchange rate used to convert source currency amounts to customer currency amounts.
        /// </summary>
        [JsonProperty("fx_rate")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("fx_rate")]
        public decimal FxRate { get; set; }

        /// <summary>
        /// Creation currency of the CheckoutSession before localization.
        /// </summary>
        [JsonProperty("source_currency")]
        [STJS.JsonPropertyName("source_currency")]
        public string SourceCurrency { get; set; }
    }
}
