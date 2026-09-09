// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportSignalsFraudulentPhone : StripeEntity<VerificationReportSignalsFraudulentPhone>
    {
        /// <summary>
        /// Array of objects representing individual factors that contributed to the calculated risk
        /// level.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<VerificationReportSignalsFraudulentPhoneIndicator> Indicators { get; set; }

        /// <summary>
        /// Categorical assessment of the phone risk.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }
    }
}
