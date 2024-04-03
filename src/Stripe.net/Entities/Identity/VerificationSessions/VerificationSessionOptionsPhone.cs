// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionOptionsPhone : StripeEntity<VerificationSessionOptionsPhone>
    {
        /// <summary>
        /// Request one time password verification of <c>provided_details.phone</c>.
        /// </summary>
        [JsonProperty("require_verification")]
        public bool RequireVerification { get; set; }
    }
}
