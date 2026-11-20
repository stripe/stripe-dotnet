// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EvaluationOutcomeDelinquency : StripeEntity<EvaluationOutcomeDelinquency>
    {
        /// <summary>
        /// The objective of the recommendation, with expected financial outcomes for the
        /// recommended controls and the current configuration when those outcomes can be
        /// quantified.
        /// </summary>
        [JsonProperty("business_objective")]
        [STJS.JsonPropertyName("business_objective")]
        public EvaluationOutcomeDelinquencyBusinessObjective BusinessObjective { get; set; }

        /// <summary>
        /// Risk controls recommended to manage the account's delinquency risk.
        /// </summary>
        [JsonProperty("controls")]
        [STJS.JsonPropertyName("controls")]
        public List<EvaluationOutcomeDelinquencyControl> Controls { get; set; }

        /// <summary>
        /// The balance between loss protection and revenue used to generate this recommendation.
        /// </summary>
        [JsonProperty("risk_appetite")]
        [STJS.JsonPropertyName("risk_appetite")]
        public EvaluationOutcomeDelinquencyRiskAppetite RiskAppetite { get; set; }

        /// <summary>
        /// Signals that informed this evaluation, with their values at evaluation time. Null when
        /// unavailable.
        /// </summary>
        [JsonProperty("supporting_signals")]
        [STJS.JsonPropertyName("supporting_signals")]
        public EvaluationOutcomeDelinquencySupportingSignals SupportingSignals { get; set; }
    }
}
