namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardShippingOptions : INestedOptions
    {
        /// <summary>
        /// The address that the card is shipped to.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The name printed on the shipping label when shipping the card.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipment service.
        /// One of: <c>express</c>, <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// Packaging options.
        /// One of: <c>bulk</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
