// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargeFraudDetails : StripeEntity<ChargeFraudDetails>
    {
        /// <summary>
        /// Assessments from Stripe. If set, the value is <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("stripe_report")]
        [STJS.JsonPropertyName("stripe_report")]
        public string StripeReport { get; set; }

        /// <summary>
        /// Assessments reported by you. If set, possible values of are <c>safe</c> and
        /// <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("user_report")]
        [STJS.JsonPropertyName("user_report")]
        public string UserReport { get; set; }
    }
}
