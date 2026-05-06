// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CapabilityProtectionsPspMigration : StripeEntity<CapabilityProtectionsPspMigration>
    {
        /// <summary>
        /// Time at which the protection expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the protection was requested. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("requested_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("requested_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime RequestedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The status of the capability protection.
        /// One of: <c>active</c>, <c>disrupted</c>, <c>expired</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
