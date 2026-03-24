// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityOptions : INestedOptions
    {
        /// <summary>
        /// Attestations from the identity's key people, e.g. owners, executives, directors,
        /// representatives.
        /// </summary>
        [JsonProperty("attestations")]
        [STJS.JsonPropertyName("attestations")]
        public AccountTokenCreateIdentityAttestationsOptions Attestations { get; set; }

        /// <summary>
        /// Information about the company or business.
        /// </summary>
        [JsonProperty("business_details")]
        [STJS.JsonPropertyName("business_details")]
        public AccountTokenCreateIdentityBusinessDetailsOptions BusinessDetails { get; set; }

        /// <summary>
        /// The entity type.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("entity_type")]
        [STJS.JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// Information about the person represented by the account.
        /// </summary>
        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public AccountTokenCreateIdentityIndividualOptions Individual { get; set; }
    }
}
