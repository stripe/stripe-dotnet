// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportDocumentIssuedDate : StripeEntity<VerificationReportDocumentIssuedDate>
    {
        /// <summary>
        /// Numerical day between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
        public long? Day { get; set; }

        /// <summary>
        /// Numerical month between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year.
        /// </summary>
        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
