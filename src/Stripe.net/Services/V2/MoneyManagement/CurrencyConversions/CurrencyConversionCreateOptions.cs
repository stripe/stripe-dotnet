// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CurrencyConversionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The FinancialAccount id to create the CurrencyConversion on.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// From amount object indicating the from currency or optional amount.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public CurrencyConversionCreateFromOptions From { get; set; }

        /// <summary>
        /// To amount object indicating the to currency or optional amount.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public CurrencyConversionCreateToOptions To { get; set; }
    }
}
