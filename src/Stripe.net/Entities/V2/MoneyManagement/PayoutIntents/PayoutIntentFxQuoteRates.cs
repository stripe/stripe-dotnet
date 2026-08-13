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
        /// The exchange rate going from_currency -&gt; to_currency, represented as a decimal string
        /// (e.g., "1.1520") to preserve the full precision of the rate.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }
    }
}
