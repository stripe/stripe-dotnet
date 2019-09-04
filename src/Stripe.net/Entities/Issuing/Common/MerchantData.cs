namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class MerchantData : StripeEntity<MerchantData>
    {
        /// <summary>
        /// A categorization of the seller’s type of business.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

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
        /// Identifier assigned to the seller by the card brand.
        /// </summary>
        [JsonProperty("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// Postal code where the seller is located.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State where the seller is locateds
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The url an online purchase was made from.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
