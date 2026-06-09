// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerEvaluationEvaluationContextClientDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Raw client metadata fallback in case a Radar Session is unavailable.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public CustomerEvaluationEvaluationContextClientDetailsDataOptions Data { get; set; }

        /// <summary>
        /// ID for the Radar Session. Required unless data is provided.
        /// </summary>
        [JsonProperty("radar_session")]
        [STJS.JsonPropertyName("radar_session")]
        public string RadarSession { get; set; }
    }
}
