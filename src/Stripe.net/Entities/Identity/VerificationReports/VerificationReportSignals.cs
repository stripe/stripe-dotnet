// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportSignals : StripeEntity<VerificationReportSignals>
    {
        [JsonProperty("fraudulent_email")]
        [STJS.JsonPropertyName("fraudulent_email")]
        public VerificationReportSignalsFraudulentEmail FraudulentEmail { get; set; }

        [JsonProperty("fraudulent_person")]
        [STJS.JsonPropertyName("fraudulent_person")]
        public VerificationReportSignalsFraudulentPerson FraudulentPerson { get; set; }

        [JsonProperty("fraudulent_phone")]
        [STJS.JsonPropertyName("fraudulent_phone")]
        public VerificationReportSignalsFraudulentPhone FraudulentPhone { get; set; }
    }
}
