// File generated from our OpenAPI spec
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
        /// Customs information for the shipment.
        /// </summary>
        [JsonProperty("customs")]
        public CardShippingCustomsOptions Customs { get; set; }

        /// <summary>
        /// The name printed on the shipping label when shipping the card.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of the recipient of the shipment.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether a signature is required for card delivery.
        /// </summary>
        [JsonProperty("require_signature")]
        public bool? RequireSignature { get; set; }

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
