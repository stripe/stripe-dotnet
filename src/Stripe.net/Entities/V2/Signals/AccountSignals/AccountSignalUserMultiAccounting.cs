// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalUserMultiAccounting : StripeEntity<AccountSignalUserMultiAccounting>
    {
        /// <summary>
        /// Categorical assessment of the multi-accounting risk.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// The specific risk score for the account, between 0.00 and 100.00. Absent when risk level
        /// is not_assessed or unknown, or when the user is not on a product tier that includes
        /// numeric scores.
        /// </summary>
        [JsonProperty("score")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("score")]
        public decimal? Score { get; set; }
    }
}
