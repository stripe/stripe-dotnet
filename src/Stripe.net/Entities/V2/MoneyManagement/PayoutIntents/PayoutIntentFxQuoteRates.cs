// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentFxQuoteRates : StripeEntity<PayoutIntentFxQuoteRates>
    {
        /// <summary>
        /// The exchange rate from the source currency to <c>to_currency</c>, represented as a
        /// decimal string (for example, <c>1.1520</c>) to preserve the full precision of the rate.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }
    }
}
