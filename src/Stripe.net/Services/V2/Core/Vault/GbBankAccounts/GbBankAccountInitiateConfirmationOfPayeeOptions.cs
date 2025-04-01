// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GbBankAccountInitiateConfirmationOfPayeeOptions : BaseOptions
    {
        /// <summary>
        /// The business type to be checked against. Legal entity information will be used if
        /// unspecified.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("business_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_type")]
#endif
        public string BusinessType { get; set; }

        /// <summary>
        /// The name of the user to be checked against. Legal entity information will be used if
        /// unspecified.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }
    }
}
