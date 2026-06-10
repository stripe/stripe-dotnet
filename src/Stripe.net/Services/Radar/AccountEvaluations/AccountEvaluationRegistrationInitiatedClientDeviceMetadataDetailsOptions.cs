// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Raw client metadata fallback when Stripe.js is blocked. Required unless radar_session is
        /// provided.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public AccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsDataOptions Data { get; set; }

        /// <summary>
        /// ID for the Radar Session. Required unless data is provided.
        /// </summary>
        [JsonProperty("radar_session")]
        [STJS.JsonPropertyName("radar_session")]
        public string RadarSession { get; set; }
    }
}
