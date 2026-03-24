// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportDocumentDob : StripeEntity<VerificationReportDocumentDob>
    {
        /// <summary>
        /// Numerical day between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
        [STJS.JsonPropertyName("day")]
        public long? Day { get; set; }

        /// <summary>
        /// Numerical month between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year.
        /// </summary>
        [JsonProperty("year")]
        [STJS.JsonPropertyName("year")]
        public long? Year { get; set; }
    }
}
