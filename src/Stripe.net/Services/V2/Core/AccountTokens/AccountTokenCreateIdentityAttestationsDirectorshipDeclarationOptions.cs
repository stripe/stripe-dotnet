// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityAttestationsDirectorshipDeclarationOptions : INestedOptions
    {
        /// <summary>
        /// A boolean indicating if the directors information has been attested.
        /// </summary>
        [JsonProperty("attested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attested")]
#endif
        public bool? Attested { get; set; }
    }
}
