// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationRecipientCapabilitiesCardsProtectionsPspMigration : StripeEntity<AccountConfigurationRecipientCapabilitiesCardsProtectionsPspMigration>
    {
        /// <summary>
        /// The time until which the protection will expire, as a Unix timestamp.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// The time at which the protection was requested, as a Unix timestamp.
        /// </summary>
        [JsonProperty("requested_at")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("requested_at")]
        public long RequestedAt { get; set; }

        /// <summary>
        /// The current status of the protection.
        /// One of: <c>active</c>, <c>disrupted</c>, <c>expired</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
