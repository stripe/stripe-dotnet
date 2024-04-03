// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportPhone : StripeEntity<VerificationReportPhone>
    {
        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        public VerificationReportPhoneError Error { get; set; }

        /// <summary>
        /// Phone to be verified.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Status of this <c>phone</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
