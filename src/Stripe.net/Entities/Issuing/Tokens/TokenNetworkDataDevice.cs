// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenNetworkDataDevice : StripeEntity<TokenNetworkDataDevice>
    {
        /// <summary>
        /// An obfuscated ID derived from the device ID.
        /// </summary>
        [JsonProperty("device_fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device_fingerprint")]
#endif

        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// The IP address of the device at provisioning time.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif

        public string IpAddress { get; set; }

        /// <summary>
        /// The geographic latitude/longitude coordinates of the device at provisioning time. The
        /// format is [+-]decimal/[+-]decimal.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif

        public string Location { get; set; }

        /// <summary>
        /// The name of the device used for tokenization.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// The phone number of the device used for tokenization.
        /// </summary>
        [JsonProperty("phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number")]
#endif

        public string PhoneNumber { get; set; }

        /// <summary>
        /// The type of device used for tokenization.
        /// One of: <c>other</c>, <c>phone</c>, or <c>watch</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
