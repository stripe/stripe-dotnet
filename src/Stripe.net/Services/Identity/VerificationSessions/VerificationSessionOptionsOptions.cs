// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class VerificationSessionOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Options that apply to the <a
        /// href="https://docs.stripe.com/identity/verification-checks?type=document">document
        /// check</a>.
        /// </summary>
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public VerificationSessionOptionsDocumentOptions Document { get; set; }
    }
}
