// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionOptionsEmail : StripeEntity<VerificationSessionOptionsEmail>
    {
        /// <summary>
        /// Request one time password verification of <c>provided_details.email</c>.
        /// </summary>
        [JsonProperty("require_verification")]
        public bool RequireVerification { get; set; }
    }
}
