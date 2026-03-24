// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteFxQuoteRates : StripeEntity<OutboundPaymentQuoteFxQuoteRates>
    {
        /// <summary>
        /// The exchange rate going from_currency -&gt; to_currency.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }
    }
}
