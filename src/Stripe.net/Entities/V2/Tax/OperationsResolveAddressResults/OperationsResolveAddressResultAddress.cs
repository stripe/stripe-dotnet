// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OperationsResolveAddressResultAddress : StripeEntity<OperationsResolveAddressResultAddress>
    {
        /// <summary>
        /// The city.
        /// </summary>
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// The two-letter country code.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The first line of the street address.
        /// </summary>
        [JsonProperty("line1")]
        [STJS.JsonPropertyName("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state or province.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
