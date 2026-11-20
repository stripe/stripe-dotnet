// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquencySupportingSignalsPaymentDelinquencyExposure : StripeEntity<EvaluationOutcomeDelinquencySupportingSignalsPaymentDelinquencyExposure>
    {
        /// <summary>
        /// Time the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Exposure if the account becomes delinquent.
        /// </summary>
        [JsonProperty("exposure_amount")]
        [STJS.JsonPropertyName("exposure_amount")]
        public V2.Amount ExposureAmount { get; set; }

        /// <summary>
        /// ID of the supporting account signal.
        /// </summary>
        [JsonProperty("signal")]
        [STJS.JsonPropertyName("signal")]
        public string Signal { get; set; }
    }
}
