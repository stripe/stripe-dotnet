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
        /// The merchant category code for the seller's business.
        /// </summary>
        [JsonProperty("category_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category_code")]
#endif
        public string CategoryCode { get; set; }

        /// <summary>
        /// Country where the seller is located.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Name of the seller.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Identifier assigned to the seller by the card network. Different card networks may
        /// assign different network_id fields to the same merchant.
        /// </summary>
        [JsonProperty("network_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_id")]
#endif
        public string NetworkId { get; set; }

        /// <summary>
        /// An ID assigned by the seller to the location of the sale.
        /// </summary>
        [JsonProperty("terminal_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terminal_id")]
#endif
        public string TerminalId { get; set; }
    }
}
