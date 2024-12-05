// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionProvidedDetailsOptions : INestedOptions
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
