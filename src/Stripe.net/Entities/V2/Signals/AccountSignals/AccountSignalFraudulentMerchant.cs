// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalFraudulentMerchant : StripeEntity<AccountSignalFraudulentMerchant>
    {
        /// <summary>
        /// Supplementary contextual data for the signal, including indicators.
        /// </summary>
        [JsonProperty("additional_details")]
        [STJS.JsonPropertyName("additional_details")]
        public AccountSignalFraudulentMerchantAdditionalDetails AdditionalDetails { get; set; }

        /// <summary>
        /// The probability of the merchant being fraudulent. Can be between 0.00 and 100.00. Absent
        /// when risk level is unknown, or when the user is not on a product tier that includes
        /// numeric scores.
        /// </summary>
        [JsonProperty("probability")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("probability")]
        public decimal? Probability { get; set; }

        /// <summary>
        /// Categorical assessment of the fraudulent merchant risk based on probability.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }
    }
}
