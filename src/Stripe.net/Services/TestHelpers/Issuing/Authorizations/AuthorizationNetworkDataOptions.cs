// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationNetworkDataOptions : INestedOptions
    {
        /// <summary>
        /// Identifier assigned to the acquirer by the card network.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acquiring_institution_id")]
#endif

        public string AcquiringInstitutionId { get; set; }
    }
}
