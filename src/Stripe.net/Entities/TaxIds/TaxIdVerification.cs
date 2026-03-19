// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxIdVerification : StripeEntity<TaxIdVerification>
    {
        /// <summary>
        /// Verification status, one of <c>pending</c>, <c>verified</c>, <c>unverified</c>, or
        /// <c>unavailable</c>.
        /// One of: <c>pending</c>, <c>unavailable</c>, <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Verified address.
        /// </summary>
        [JsonProperty("verified_address")]
        [STJS.JsonPropertyName("verified_address")]
        public string VerifiedAddress { get; set; }

        /// <summary>
        /// Verified name.
        /// </summary>
        [JsonProperty("verified_name")]
        [STJS.JsonPropertyName("verified_name")]
        public string VerifiedName { get; set; }
    }
}
