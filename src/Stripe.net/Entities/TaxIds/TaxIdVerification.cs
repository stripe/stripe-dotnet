// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TaxIdVerification : StripeEntity<TaxIdVerification>
    {
        /// <summary>
        /// Verification status, one of <c>pending</c>, <c>verified</c>, <c>unverified</c>, or
        /// <c>unavailable</c>.
        /// One of: <c>pending</c>, <c>unavailable</c>, <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Verified address.
        /// </summary>
        [JsonProperty("verified_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_address")]
#endif
        public string VerifiedAddress { get; set; }

        /// <summary>
        /// Verified name.
        /// </summary>
        [JsonProperty("verified_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_name")]
#endif
        public string VerifiedName { get; set; }
    }
}
