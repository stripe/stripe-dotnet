// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionRelinkOptionsOptions : INestedOptions
    {
        /// <summary>
        /// The account to relink. Must belong to the authorization specified in
        /// <c>authorization</c>.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The authorization to relink.
        /// </summary>
        [JsonProperty("authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization")]
#endif
        public string Authorization { get; set; }
    }
}
