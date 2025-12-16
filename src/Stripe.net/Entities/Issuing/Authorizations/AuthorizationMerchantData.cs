// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationMerchantData : StripeEntity<AuthorizationMerchantData>
    {
        /// <summary>
        /// A categorization of the seller's type of business. See our <a
        /// href="https://docs.stripe.com/issuing/merchant-categories">merchant categories guide</a>
        /// for a list of possible values.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// The merchant category code for the seller’s business.
        /// </summary>
        [JsonProperty("category_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category_code")]
#endif
        public string CategoryCode { get; set; }

        /// <summary>
        /// City where the seller is located.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

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
        /// Postal code where the seller is located.
        /// </summary>
        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif
        public string PostalCode { get; set; }

        /// <summary>
        /// State where the seller is located.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// The seller's tax identification number. Currently populated for French merchants only.
        /// </summary>
        [JsonProperty("tax_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id")]
#endif
        public string TaxId { get; set; }

        /// <summary>
        /// An ID assigned by the seller to the location of the sale.
        /// </summary>
        [JsonProperty("terminal_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terminal_id")]
#endif
        public string TerminalId { get; set; }

        /// <summary>
        /// URL provided by the merchant on a 3DS request.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
