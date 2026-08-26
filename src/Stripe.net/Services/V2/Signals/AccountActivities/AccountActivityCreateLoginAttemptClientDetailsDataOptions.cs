// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountActivityCreateLoginAttemptClientDetailsDataOptions : INestedOptions
    {
        /// <summary>
        /// The IP address associated with the activity.
        /// </summary>
        [JsonProperty("ip")]
        [STJS.JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The referrer associated with the activity.
        /// </summary>
        [JsonProperty("referrer")]
        [STJS.JsonPropertyName("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// The user agent associated with the activity.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
