// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationRiskAssessmentFraudRiskOptions : INestedOptions
    {
        /// <summary>
        /// Stripe’s assessment of the likelihood of fraud on an authorization.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("level")]
#endif
        public string Level { get; set; }

        /// <summary>
        /// Stripe’s numerical model score assessing the likelihood of fraudulent activity. A higher
        /// score means a higher likelihood of fraudulent activity, and anything above 25 is
        /// considered high risk.
        /// </summary>
        [JsonProperty("score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("score")]
#endif
        public decimal? Score { get; set; }
    }
}
