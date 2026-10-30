// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CurrencyConversionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Financial Account in which the Currency Conversion should be created. If
        /// omitted, it will be created in the payments balance.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The source currency to debit, optionally including an amount. Either <c>from</c> or
        /// <c>to</c> must contain a specific amount (but not both).
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public CurrencyConversionCreateFromOptions From { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/fx_quotes">FX Quote</a> to use.
        /// </summary>
        [JsonProperty("fx_quote")]
        [STJS.JsonPropertyName("fx_quote")]
        public string FxQuote { get; set; }

        /// <summary>
        /// The destination currency to credit, optionally including an amount.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public CurrencyConversionCreateToOptions To { get; set; }
    }
}
