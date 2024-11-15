// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardShippingOptions : INestedOptions
    {
        /// <summary>
        /// The address that the card is shipped to.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif

        public AddressOptions Address { get; set; }

        /// <summary>
        /// Address validation settings.
        /// </summary>
        [JsonProperty("address_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_validation")]
#endif

        public CardShippingAddressValidationOptions AddressValidation { get; set; }

        /// <summary>
        /// Customs information for the shipment.
        /// </summary>
        [JsonProperty("customs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customs")]
#endif

        public CardShippingCustomsOptions Customs { get; set; }

        /// <summary>
        /// The name printed on the shipping label when shipping the card.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// Phone number of the recipient of the shipment.
        /// </summary>
        [JsonProperty("phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number")]
#endif

        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether a signature is required for card delivery.
        /// </summary>
        [JsonProperty("require_signature")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("require_signature")]
#endif

        public bool? RequireSignature { get; set; }

        /// <summary>
        /// Shipment service.
        /// One of: <c>express</c>, <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service")]
#endif

        public string Service { get; set; }

        /// <summary>
        /// Packaging options.
        /// One of: <c>bulk</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
