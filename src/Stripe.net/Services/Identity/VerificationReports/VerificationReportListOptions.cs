// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationReportListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return VerificationReports of this type.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Only return VerificationReports created by this VerificationSession ID. It is allowed to
        /// provide a VerificationIntent ID.
        /// </summary>
        [JsonProperty("verification_session")]
        public string VerificationSession { get; set; }
    }
}
