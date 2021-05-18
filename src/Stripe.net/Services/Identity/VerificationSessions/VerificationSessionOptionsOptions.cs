// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Verification configuration options for the <c>document</c> record_type.
        /// </summary>
        [JsonProperty("document")]
        public VerificationSessionOptionsDocumentOptions Document { get; set; }
    }
}
