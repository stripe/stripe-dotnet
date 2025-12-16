// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances to create cards for commercial issuing use cases.
        /// </summary>
        [JsonProperty("commercial")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("commercial")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorCommercialOptions Commercial { get; set; }
    }
}
