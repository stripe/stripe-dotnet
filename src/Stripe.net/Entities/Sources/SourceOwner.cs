// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceOwner : StripeEntity<SourceOwner>
    {
        /// <summary>
        /// Owner's address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// Owner's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// Owner's full name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Owner's phone number (including extension).
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// Verified owner's address. Verified values are verified or provided by the payment method
        /// directly (and if supported) at the time of authorization or settlement. They cannot be
        /// set or mutated.
        /// </summary>
        [JsonProperty("verified_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_address")]
#endif
        public Address VerifiedAddress { get; set; }

        /// <summary>
        /// Verified owner's email address. Verified values are verified or provided by the payment
        /// method directly (and if supported) at the time of authorization or settlement. They
        /// cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_email")]
#endif
        public string VerifiedEmail { get; set; }

        /// <summary>
        /// Verified owner's full name. Verified values are verified or provided by the payment
        /// method directly (and if supported) at the time of authorization or settlement. They
        /// cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_name")]
#endif
        public string VerifiedName { get; set; }

        /// <summary>
        /// Verified owner's phone number (including extension). Verified values are verified or
        /// provided by the payment method directly (and if supported) at the time of authorization
        /// or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_phone")]
#endif
        public string VerifiedPhone { get; set; }
    }
}
