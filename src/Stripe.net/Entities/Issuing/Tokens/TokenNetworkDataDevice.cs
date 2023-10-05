// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TokenNetworkDataDevice : StripeEntity<TokenNetworkDataDevice>
    {
        /// <summary>
        /// An obfuscated ID derived from the device ID.
        /// </summary>
        [JsonProperty("device_fingerprint")]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// The IP address of the device at provisioning time.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The geographic latitude/longitude coordinates of the device at provisioning time. The
        /// format is [+-]decimal/[+-]decimal.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// The name of the device used for tokenization.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the device used for tokenization.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The type of device used for tokenization.
        /// One of: <c>other</c>, <c>phone</c>, or <c>watch</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
