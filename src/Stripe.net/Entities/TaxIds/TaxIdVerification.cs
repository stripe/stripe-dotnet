namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdVerification : StripeEntity<TaxIdVerification>
    {
        /// <summary>
        /// Verification status, one of <c>pending</c>, <c>unavailable</c>, <c>unverified</c>, or
        /// <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The official address associated with the tax ID returned from the external provider.
        /// </summary>
        [JsonProperty("verified_address")]
        public string VerifiedAddress { get; set; }

        /// <summary>
        /// The official name associated with the tax ID returned from the external provider.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
