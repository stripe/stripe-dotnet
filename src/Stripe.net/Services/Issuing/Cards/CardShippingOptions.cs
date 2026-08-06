// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardShippingOptions : INestedOptions
    {
        /// <summary>
        /// The address that the card is shipped to.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Address validation settings.
        /// </summary>
        [JsonProperty("address_validation")]
        [STJS.JsonPropertyName("address_validation")]
        public CardShippingAddressValidationOptions AddressValidation { get; set; }

        /// <summary>
        /// The name of the business at the shipping address, used on the shipping label to ensure
        /// delivery when the card is shipped to a cardholder's workplace. Allowed characters:
        /// <c>A-Z</c>, <c>a-z</c>, <c>0-9</c>, <c> </c>, <c>.</c>, <c>-</c>. All other characters
        /// are stripped or ASCII-normalized when printed.
        /// </summary>
        [JsonProperty("business_name")]
        [STJS.JsonPropertyName("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Customs information for the shipment.
        /// </summary>
        [JsonProperty("customs")]
        [STJS.JsonPropertyName("customs")]
        public CardShippingCustomsOptions Customs { get; set; }

        /// <summary>
        /// The name printed on the shipping label when shipping the card.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of the recipient of the shipment.
        /// </summary>
        [JsonProperty("phone_number")]
        [STJS.JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether a signature is required for card delivery.
        /// </summary>
        [JsonProperty("require_signature")]
        [STJS.JsonPropertyName("require_signature")]
        public bool? RequireSignature { get; set; }

        /// <summary>
        /// Shipment service.
        /// One of: <c>express</c>, <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("service")]
        [STJS.JsonPropertyName("service")]
        public string Service { get; set; }

        /// <summary>
        /// Packaging options.
        /// One of: <c>bulk</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
