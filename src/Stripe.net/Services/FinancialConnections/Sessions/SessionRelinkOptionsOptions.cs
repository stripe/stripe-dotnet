// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionRelinkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The account to relink. Must belong to the authorization specified in
        /// <c>authorization</c>.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The authorization to relink.
        /// </summary>
        [JsonProperty("authorization")]
        [STJS.JsonPropertyName("authorization")]
        public string Authorization { get; set; }
    }
}
