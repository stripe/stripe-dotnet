// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationRiskAssessmentCardTestingRiskOptions : INestedOptions
    {
        /// <summary>
        /// The % of declines due to a card number not existing in the past hour, taking place at
        /// the same merchant. Higher rates correspond to a greater probability of card testing
        /// activity, meaning bad actors may be attempting different card number combinations to
        /// guess a correct one. Takes on values between 0 and 100.
        /// </summary>
        [JsonProperty("invalid_account_number_decline_rate_past_hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invalid_account_number_decline_rate_past_hour")]
#endif
        public long? InvalidAccountNumberDeclineRatePastHour { get; set; }

        /// <summary>
        /// The % of declines due to incorrect verification data (like CVV or expiry) in the past
        /// hour, taking place at the same merchant. Higher rates correspond to a greater
        /// probability of bad actors attempting to utilize valid card credentials at merchants with
        /// verification requirements. Takes on values between 0 and 100.
        /// </summary>
        [JsonProperty("invalid_credentials_decline_rate_past_hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invalid_credentials_decline_rate_past_hour")]
#endif
        public long? InvalidCredentialsDeclineRatePastHour { get; set; }

        /// <summary>
        /// The likelihood that this authorization is associated with card testing activity. This is
        /// assessed by evaluating decline activity over the last hour.
        /// One of: <c>elevated</c>, <c>high</c>, <c>highest</c>, <c>normal</c>,
        /// <c>not_assessed</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("risk_level")]
#endif
        public string RiskLevel { get; set; }
    }
}
