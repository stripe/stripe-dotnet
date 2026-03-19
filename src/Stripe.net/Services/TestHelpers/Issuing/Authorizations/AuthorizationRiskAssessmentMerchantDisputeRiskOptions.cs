// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationRiskAssessmentMerchantDisputeRiskOptions : INestedOptions
    {
        /// <summary>
        /// The dispute rate observed across all Stripe Issuing authorizations for this merchant.
        /// For example, a value of 50 means 50% of authorizations from this merchant on Stripe
        /// Issuing have resulted in a dispute. Higher values mean a higher likelihood the
        /// authorization is disputed. Takes on values between 0 and 100.
        /// </summary>
        [JsonProperty("dispute_rate")]
        [STJS.JsonPropertyName("dispute_rate")]
        public long? DisputeRate { get; set; }

        /// <summary>
        /// The likelihood that authorizations from this merchant will result in a dispute based on
        /// their history on Stripe Issuing.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("level")]
        [STJS.JsonPropertyName("level")]
        public string Level { get; set; }
    }
}
