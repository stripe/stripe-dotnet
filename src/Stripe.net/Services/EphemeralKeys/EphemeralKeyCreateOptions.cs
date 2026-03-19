// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class EphemeralKeyCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Customer you'd like to modify using the resulting ephemeral key.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the Issuing Card you'd like to access using the resulting ephemeral key.
        /// </summary>
        [JsonProperty("issuing_card")]
        [STJS.JsonPropertyName("issuing_card")]
        public string IssuingCard { get; set; }

        /// <summary>
        /// A single-use token, created by Stripe.js, used for creating ephemeral keys for Issuing
        /// Cards without exchanging sensitive information.
        /// </summary>
        [JsonProperty("nonce")]
        [STJS.JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        [JsonIgnore]
        [STJS.JsonIgnore]
        public string StripeVersion { get; set; }

        /// <summary>
        /// The ID of the Identity VerificationSession you'd like to access using the resulting
        /// ephemeral key.
        /// </summary>
        [JsonProperty("verification_session")]
        [STJS.JsonPropertyName("verification_session")]
        public string VerificationSession { get; set; }
    }
}
