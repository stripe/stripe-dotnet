// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionOptionsPhone : StripeEntity<VerificationSessionOptionsPhone>
    {
        /// <summary>
        /// Request one time password verification of <c>provided_details.phone</c>.
        /// </summary>
        [JsonProperty("require_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("require_verification")]
#endif
        public bool RequireVerification { get; set; }
    }
}
