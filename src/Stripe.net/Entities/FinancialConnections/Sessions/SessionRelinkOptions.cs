// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionRelinkOptions : StripeEntity<SessionRelinkOptions>
    {
        /// <summary>
        /// Requires the end user to repair this specific account during the authentication flow
        /// instead of connecting a different one.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The authorization to relink in the Session.
        /// </summary>
        [JsonProperty("authorization")]
        [STJS.JsonPropertyName("authorization")]
        public string Authorization { get; set; }
    }
}
