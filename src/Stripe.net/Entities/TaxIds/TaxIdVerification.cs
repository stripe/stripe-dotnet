namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdVerification : StripeEntity<TaxIdVerification>
    {
        /// <summary>
        /// Verification status, one of <c>pending</c>, <c>verified</c>, <c>unverified</c>, or
        /// <c>unavailable</c>.
        /// One of: <c>pending</c>, <c>unavailable</c>, <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Verified address.
        /// </summary>
        [JsonProperty("verified_address")]
        public string VerifiedAddress { get; set; }

        /// <summary>
        /// Verified name.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
