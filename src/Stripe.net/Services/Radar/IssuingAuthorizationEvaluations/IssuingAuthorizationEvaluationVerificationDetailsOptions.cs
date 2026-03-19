// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuingAuthorizationEvaluationVerificationDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The outcome of the 3D Secure authentication request.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>exempted</c>,
        /// <c>failed</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("three_d_secure_result")]
        [STJS.JsonPropertyName("three_d_secure_result")]
        public string ThreeDSecureResult { get; set; }
    }
}
