// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationVerificationDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The result of 3D Secure verification.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>exempted</c>,
        /// <c>failed</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("three_d_secure_result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure_result")]
#endif
        public string ThreeDSecureResult { get; set; }
    }
}
