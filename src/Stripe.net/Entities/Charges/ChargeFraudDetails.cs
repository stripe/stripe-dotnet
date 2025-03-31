// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargeFraudDetails : StripeEntity<ChargeFraudDetails>
    {
        /// <summary>
        /// Assessments from Stripe. If set, the value is <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("stripe_report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_report")]
#endif
        public string StripeReport { get; set; }

        /// <summary>
        /// Assessments reported by you. If set, possible values of are <c>safe</c> and
        /// <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("user_report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_report")]
#endif
        public string UserReport { get; set; }
    }
}
