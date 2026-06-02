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

        /// <summary>
        /// The decision made during token provisioning.
        /// One of: <c>approve</c>, <c>approve_pending_id_and_v</c>, or <c>decline</c>.
        /// </summary>
        [JsonProperty("provisioning_decision")]
        [STJS.JsonPropertyName("provisioning_decision")]
        public string ProvisioningDecision { get; set; }

        /// <summary>
        /// The type of the token, indicating how it is used.
        /// One of: <c>card_on_file</c>, <c>cloud_based</c>, <c>commerce_platform</c>,
        /// <c>commercial_virtual_account</c>, <c>secure_element</c>, or <c>static_credential</c>.
        /// </summary>
        [JsonProperty("token_type")]
        [STJS.JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
}
