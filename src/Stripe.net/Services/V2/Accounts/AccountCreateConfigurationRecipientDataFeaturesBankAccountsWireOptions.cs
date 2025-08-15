// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationRecipientDataFeaturesBankAccountsWireOptions : INestedOptions
    {
        /// <summary>
        /// Whether or not to request the Feature.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public bool? Requested { get; set; }
    }
}
