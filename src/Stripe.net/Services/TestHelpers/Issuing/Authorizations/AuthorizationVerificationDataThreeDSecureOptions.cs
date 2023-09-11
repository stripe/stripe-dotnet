// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationDataThreeDSecureOptions : INestedOptions
    {
        /// <summary>
        /// The outcome of the 3D Secure authentication request.
        /// One of: <c>attempt_acknowledged</c>, <c>authenticated</c>, <c>failed</c>, or
        /// <c>required</c>.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
