// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentQuoteFxQuoteRates : StripeEntity<OutboundPaymentQuoteFxQuoteRates>
    {
        /// <summary>
        /// The exchange rate going from_currency -&gt; to_currency.
        /// </summary>
        [JsonProperty("exchange_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exchange_rate")]
#endif
        public string ExchangeRate { get; set; }
    }
}
