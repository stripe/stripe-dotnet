// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionProvidedDetails : StripeEntity<VerificationSessionProvidedDetails>
    {
        /// <summary>
        /// Email of user being verified.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone number of user being verified.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
