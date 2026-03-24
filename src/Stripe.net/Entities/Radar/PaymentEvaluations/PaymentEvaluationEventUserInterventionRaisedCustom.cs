// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationEventUserInterventionRaisedCustom : StripeEntity<PaymentEvaluationEventUserInterventionRaisedCustom>
    {
        /// <summary>
        /// Custom type of user intervention raised. The string must use a snake case description
        /// for the type of intervention performed.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
