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
        /// The FinancialAccount id to create the CurrencyConversion on.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// From amount object indicating the from currency or optional amount.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public CurrencyConversionCreateFromOptions From { get; set; }

        /// <summary>
        /// The FX quote to use for the conversion.
        /// </summary>
        [JsonProperty("fx_quote")]
        [STJS.JsonPropertyName("fx_quote")]
        public string FxQuote { get; set; }

        /// <summary>
        /// To amount object indicating the to currency or optional amount.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public CurrencyConversionCreateToOptions To { get; set; }
    }
}
