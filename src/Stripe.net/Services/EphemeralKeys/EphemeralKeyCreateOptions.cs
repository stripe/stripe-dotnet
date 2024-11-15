// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EphemeralKeyCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Customer you'd like to modify using the resulting ephemeral key.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// The ID of the Issuing Card you'd like to access using the resulting ephemeral key.
        /// </summary>
        [JsonProperty("issuing_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_card")]
#endif

        public string IssuingCard { get; set; }

        /// <summary>
        /// A single-use token, created by Stripe.js, used for creating ephemeral keys for Issuing
        /// Cards without exchanging sensitive information.
        /// </summary>
        [JsonProperty("nonce")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nonce")]
#endif

        public string Nonce { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string StripeVersion { get; set; }

        /// <summary>
        /// The ID of the Identity VerificationSession you'd like to access using the resulting
        /// ephemeral key.
        /// </summary>
        [JsonProperty("verification_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_session")]
#endif

        public string VerificationSession { get; set; }
    }
}
