// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuingAuthorizationEvaluationMerchantDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The merchant category code for the seller's business.
        /// </summary>
        [JsonProperty("category_code")]
        [STJS.JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Country where the seller is located.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Name of the seller.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier assigned to the seller by the card network. Different card networks may
        /// assign different network_id fields to the same merchant.
        /// </summary>
        [JsonProperty("network_id")]
        [STJS.JsonPropertyName("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// An ID assigned by the seller to the location of the sale.
        /// </summary>
        [JsonProperty("terminal_id")]
        [STJS.JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }
    }
}
