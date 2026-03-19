// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TokenNetworkDataDevice : StripeEntity<TokenNetworkDataDevice>
    {
        /// <summary>
        /// An obfuscated ID derived from the device ID.
        /// </summary>
        [JsonProperty("device_fingerprint")]
        [STJS.JsonPropertyName("device_fingerprint")]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// The IP address of the device at provisioning time.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The geographic latitude/longitude coordinates of the device at provisioning time. The
        /// format is [+-]decimal/[+-]decimal.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// The name of the device used for tokenization.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the device used for tokenization.
        /// </summary>
        [JsonProperty("phone_number")]
        [STJS.JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The type of device used for tokenization.
        /// One of: <c>other</c>, <c>phone</c>, or <c>watch</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
