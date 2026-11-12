// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class VerificationSessionLinkSharedDataOptions : INestedOptions
    {
        /// <summary>
        /// The LinkSharedData grant authorizing use of a shared identity document. Requires
        /// confirm=true.
        /// </summary>
        [JsonProperty("granted_token")]
        [STJS.JsonPropertyName("granted_token")]
        public string GrantedToken { get; set; }

        /// <summary>
        /// The identity_data.identity_documents[].key returned for this grant. Required even when
        /// the grant contains only one document.
        /// </summary>
        [JsonProperty("identity_document")]
        [STJS.JsonPropertyName("identity_document")]
        public string IdentityDocument { get; set; }
    }
}
