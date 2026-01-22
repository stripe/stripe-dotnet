// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationEventUserInterventionRaisedCustom : StripeEntity<PaymentEvaluationEventUserInterventionRaisedCustom>
    {
        /// <summary>
        /// Custom type of user intervention raised. The string must use a snake case description
        /// for the type of intervention performed.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
