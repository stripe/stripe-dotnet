// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationMerchantData : StripeEntity<AuthorizationMerchantData>
    {
        /// <summary>
        /// A categorization of the seller's type of business. See our <a
        /// href="https://stripe.com/docs/issuing/merchant-categories">merchant categories guide</a>
        /// for a list of possible values.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The merchant category code for the seller’s business.
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// City where the seller is located.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Country where the seller is located.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Name of the seller.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier assigned to the seller by the card network. Different card networks may
        /// assign different network_id fields to the same merchant.
        /// </summary>
        [JsonProperty("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// Postal code where the seller is located.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State where the seller is located.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// An ID assigned by the seller to the location of the sale.
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// URL provided by the merchant on a 3DS request.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
