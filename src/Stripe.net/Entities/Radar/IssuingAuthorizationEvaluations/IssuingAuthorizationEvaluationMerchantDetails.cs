// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationMerchantDetails : StripeEntity<IssuingAuthorizationEvaluationMerchantDetails>
    {
        /// <summary>
        /// The merchant category code (MCC).
        /// </summary>
        [JsonProperty("category_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category_code")]
#endif
        public string CategoryCode { get; set; }

        /// <summary>
        /// The merchant country code.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The merchant name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The merchant identifier from the card network.
        /// </summary>
        [JsonProperty("network_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_id")]
#endif
        public string NetworkId { get; set; }

        /// <summary>
        /// The terminal identifier.
        /// </summary>
        [JsonProperty("terminal_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terminal_id")]
#endif
        public string TerminalId { get; set; }
    }
}
