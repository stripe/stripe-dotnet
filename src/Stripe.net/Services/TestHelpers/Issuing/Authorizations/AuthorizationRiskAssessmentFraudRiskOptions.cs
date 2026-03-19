// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationRiskAssessmentFraudRiskOptions : INestedOptions
    {
        /// <summary>
        /// Stripe’s assessment of the likelihood of fraud on an authorization.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("level")]
        [STJS.JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// Stripe’s numerical model score assessing the likelihood of fraudulent activity. A higher
        /// score means a higher likelihood of fraudulent activity, and anything above 25 is
        /// considered high risk.
        /// </summary>
        [JsonProperty("score")]
        [STJS.JsonPropertyName("score")]
        public decimal? Score { get; set; }
    }
}
