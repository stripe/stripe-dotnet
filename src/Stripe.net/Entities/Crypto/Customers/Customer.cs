// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// This object represents a crypto onramp customer. Use it to get their kyc status and
    /// payment methods.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Customer : StripeEntity<Customer>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The KYC region determined by the customer's address country.
        /// One of: <c>eu</c>, or <c>us</c>.
        /// </summary>
        [JsonProperty("kyc_region")]
        [STJS.JsonPropertyName("kyc_region")]
        public string KycRegion { get; set; }

        /// <summary>
        /// List of KYC tiers and their verification status.
        /// </summary>
        [JsonProperty("kyc_tiers")]
        [STJS.JsonPropertyName("kyc_tiers")]
        public List<CustomerKycTier> KycTiers { get; set; }

        /// <summary>
        /// The set of KYC Fields provided for this customers.
        /// One of: <c>address_city</c>, <c>address_country</c>, <c>address_line_1</c>,
        /// <c>address_line_2</c>, <c>address_postal_code</c>, <c>address_state</c>,
        /// <c>attestation</c>, <c>birth_city</c>, <c>birth_country</c>, <c>dob</c>,
        /// <c>first_name</c>, <c>id_document</c>, <c>id_number</c>, <c>id_type</c>,
        /// <c>identifiers</c>, <c>last_name</c>, <c>nationalities</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("provided_fields")]
        [STJS.JsonPropertyName("provided_fields")]
        public List<string> ProvidedFields { get; set; }

        /// <summary>
        /// List of verifications and their outcome.
        /// </summary>
        [JsonProperty("verifications")]
        [STJS.JsonPropertyName("verifications")]
        public List<CustomerVerification> Verifications { get; set; }
    }
}
