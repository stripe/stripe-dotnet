// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCurrencyConversion : StripeEntity<SessionCurrencyConversion>
    {
        /// <summary>
        /// Total of all items in source currency before discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total of all items in source currency after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// Creation currency of the CheckoutSession before localization.
        /// </summary>
        [JsonProperty("source_currency")]
        public string SourceCurrency { get; set; }
    }
}
