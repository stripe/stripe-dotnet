// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportSignalsFraudulentPersonIndicator : StripeEntity<VerificationReportSignalsFraudulentPersonIndicator>
    {
        /// <summary>
        /// A brief explanation of how this indicator contributed to the risk level.
        /// </summary>
        [JsonProperty("explanation")]
        [STJS.JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// The effect this indicator had on the overall risk level.
        /// One of: <c>decrease</c>, <c>neutral</c>, <c>slight_increase</c>, or
        /// <c>strong_increase</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("impact")]
        [STJS.JsonPropertyName("impact")]
        public string Impact { get; set; }

        /// <summary>
        /// The name of the specific indicator used in the risk assessment.
        /// One of: <c>fraudulent_person_match</c>, <c>no_transaction_match</c>, or <c>other</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("indicator")]
        [STJS.JsonPropertyName("indicator")]
        public string Indicator { get; set; }
    }
}
