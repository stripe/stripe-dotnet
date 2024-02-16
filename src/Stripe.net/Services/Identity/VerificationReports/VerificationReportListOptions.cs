// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class VerificationReportListOptions : ListOptionsWithCreated
    {
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

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
