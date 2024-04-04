// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Options that apply to the <a
        /// href="https://stripe.com/docs/identity/verification-checks?type=document">document
        /// check</a>.
        /// </summary>
        [JsonProperty("document")]
        public VerificationSessionOptionsDocumentOptions Document { get; set; }

        /// <summary>
        /// Options that apply to the email check.
        /// </summary>
        [JsonProperty("email")]
        public VerificationSessionOptionsEmailOptions Email { get; set; }

        /// <summary>
        /// Options that apply to the phone check.
        /// </summary>
        [JsonProperty("phone")]
        public VerificationSessionOptionsPhoneOptions Phone { get; set; }
    }
}
