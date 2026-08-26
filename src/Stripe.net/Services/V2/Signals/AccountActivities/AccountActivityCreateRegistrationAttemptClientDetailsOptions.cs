// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountActivityCreateRegistrationAttemptClientDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Raw client details for the activity, when a Radar session is not available.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public AccountActivityCreateRegistrationAttemptClientDetailsDataOptions Data { get; set; }

        /// <summary>
        /// The Radar session ID capturing client details for the activity.
        /// </summary>
        [JsonProperty("radar_session")]
        [STJS.JsonPropertyName("radar_session")]
        public string RadarSession { get; set; }
    }
}
