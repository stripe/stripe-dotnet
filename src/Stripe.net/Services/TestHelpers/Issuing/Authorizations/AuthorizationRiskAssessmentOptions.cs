// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationRiskAssessmentOptions : INestedOptions
    {
        /// <summary>
        /// Stripe's assessment of this authorization's likelihood of being card testing activity.
        /// </summary>
        [JsonProperty("card_testing_risk")]
        [STJS.JsonPropertyName("card_testing_risk")]
        public AuthorizationRiskAssessmentCardTestingRiskOptions CardTestingRisk { get; set; }

        /// <summary>
        /// Stripe’s assessment of this authorization’s likelihood to be fraudulent.
        /// </summary>
        [JsonProperty("fraud_risk")]
        [STJS.JsonPropertyName("fraud_risk")]
        public AuthorizationRiskAssessmentFraudRiskOptions FraudRisk { get; set; }

        /// <summary>
        /// The dispute risk of the merchant (the seller on a purchase) on an authorization based on
        /// all Stripe Issuing activity.
        /// </summary>
        [JsonProperty("merchant_dispute_risk")]
        [STJS.JsonPropertyName("merchant_dispute_risk")]
        public AuthorizationRiskAssessmentMerchantDisputeRiskOptions MerchantDisputeRisk { get; set; }
    }
}
