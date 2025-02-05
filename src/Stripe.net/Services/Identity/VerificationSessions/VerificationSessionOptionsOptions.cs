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
    }
}
