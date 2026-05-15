// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationCapabilityRequirementsError : StripeEntity<PaymentLocationCapabilityRequirementsError>
    {
        /// <summary>
        /// The code for the type of error.
        /// One of: <c>information_missing</c>, or <c>invalid_value_other</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// An informative message that indicates the error type and provides additional details
        /// about the error.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The specific user onboarding requirement field (in the requirements hash) that needs to
        /// be resolved.
        /// </summary>
        [JsonProperty("requirement")]
        [STJS.JsonPropertyName("requirement")]
        public string Requirement { get; set; }
    }
}
