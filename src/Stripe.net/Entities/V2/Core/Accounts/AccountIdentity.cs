// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentity : StripeEntity<AccountIdentity>
    {
        /// <summary>
        /// Attestations from the identity's key people, e.g. owners, executives, directors,
        /// representatives.
        /// </summary>
        [JsonProperty("attestations")]
        [STJS.JsonPropertyName("attestations")]
        public AccountIdentityAttestations Attestations { get; set; }

        /// <summary>
        /// Information about the company or business.
        /// </summary>
        [JsonProperty("business_details")]
        [STJS.JsonPropertyName("business_details")]
        public AccountIdentityBusinessDetails BusinessDetails { get; set; }

        /// <summary>
        /// The country in which the account holder resides, or in which the business is legally
        /// established. This should be an <a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a> country
        /// code.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The entity type represented by the Account. Ensure this field is accurate before adding
        /// configurations that rely on identity information, as it determines which identity fields
        /// apply and how the Account is validated.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("entity_type")]
        [STJS.JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// Information about the individual represented by the Account. This property is
        /// <c>null</c> unless <c>entity_type</c> is set to <c>individual</c>.
        /// </summary>
        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public AccountIdentityIndividual Individual { get; set; }
    }
}
