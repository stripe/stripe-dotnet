namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class VerificationData : StripeEntity<VerificationData>
    {
        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        /// <summary>
        /// One of <c>success</c>, <c>failure</c>, <c>exempt</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        /// <summary>
        /// One of <c>match</c>, <c>mismatch</c>, or <c>not_provided</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }
    }
}
