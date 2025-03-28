// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentQuoteFxQuote : StripeEntity<OutboundPaymentQuoteFxQuote>
    {
        /// <summary>
        /// Key pair: from currency Value: exchange rate going from_currency -&gt; to_currency.
        /// </summary>
        [JsonProperty("rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rates")]
#endif
        public Dictionary<string, OutboundPaymentQuoteFxQuoteRates> Rates { get; set; }

        /// <summary>
        /// The currency that the transaction is exchanging to.
        /// </summary>
        [JsonProperty("to_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to_currency")]
#endif
        public string ToCurrency { get; set; }
    }
}
