// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationTokenDetails : StripeEntity<AuthorizationTokenDetails>
    {
        /// <summary>
        /// The card associated with this token.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public string Card { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The hashed ID derived from the device ID from the card network associated with the
        /// token.
        /// </summary>
        [JsonProperty("device_fingerprint")]
        [STJS.JsonPropertyName("device_fingerprint")]
        public string DeviceFingerprint { get; set; }

        [JsonProperty("network_data")]
        [STJS.JsonPropertyName("network_data")]
        public AuthorizationTokenDetailsNetworkData NetworkData { get; set; }
    }
}
