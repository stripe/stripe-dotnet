// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationTokenDetails : StripeEntity<AuthorizationTokenDetails>
    {
        /// <summary>
        /// The card associated with this token.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public string Card { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The hashed ID derived from the device ID from the card network associated with the
        /// token.
        /// </summary>
        [JsonProperty("device_fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device_fingerprint")]
#endif
        public string DeviceFingerprint { get; set; }

        [JsonProperty("network_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_data")]
#endif
        public AuthorizationTokenDetailsNetworkData NetworkData { get; set; }
    }
}
