// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationRiskAssessmentOptions : INestedOptions
    {
        /// <summary>
        /// Stripe's assessment of this authorization's likelihood of being card testing activity.
        /// </summary>
        [JsonProperty("card_testing_risk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_testing_risk")]
#endif
        public AuthorizationRiskAssessmentCardTestingRiskOptions CardTestingRisk { get; set; }

        /// <summary>
        /// Stripe’s assessment of this authorization’s likelihood to be fraudulent.
        /// </summary>
        [JsonProperty("fraud_risk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraud_risk")]
#endif
        public AuthorizationRiskAssessmentFraudRiskOptions FraudRisk { get; set; }

        /// <summary>
        /// The dispute risk of the merchant (the seller on a purchase) on an authorization based on
        /// all Stripe Issuing activity.
        /// </summary>
        [JsonProperty("merchant_dispute_risk")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_dispute_risk")]
#endif
        public AuthorizationRiskAssessmentMerchantDisputeRiskOptions MerchantDisputeRisk { get; set; }
    }
}
