// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityOptions : INestedOptions
    {
        /// <summary>
        /// Attestations from the identity's key people, e.g. owners, executives, directors,
        /// representatives.
        /// </summary>
        [JsonProperty("attestations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("attestations")]
#endif
        public AccountTokenCreateIdentityAttestationsOptions Attestations { get; set; }

        /// <summary>
        /// Information about the company or business.
        /// </summary>
        [JsonProperty("business_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_details")]
#endif
        public AccountTokenCreateIdentityBusinessDetailsOptions BusinessDetails { get; set; }

        /// <summary>
        /// The entity type.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("entity_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entity_type")]
#endif
        public string EntityType { get; set; }

        /// <summary>
        /// Information about the person represented by the account.
        /// </summary>
        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif
        public AccountTokenCreateIdentityIndividualOptions Individual { get; set; }
    }
}
