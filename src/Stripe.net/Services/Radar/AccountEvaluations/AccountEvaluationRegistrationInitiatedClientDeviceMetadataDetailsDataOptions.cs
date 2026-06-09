// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationRegistrationInitiatedClientDeviceMetadataDetailsDataOptions : INestedOptions
    {
        /// <summary>
        /// The end user's IP address. Used for proxy detection and IP-clustering signals.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The referring URL of the login or registration page.
        /// </summary>
        [JsonProperty("referrer")]
        [STJS.JsonPropertyName("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// The User-Agent HTTP header.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
