// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeProvisionalCredit : StripeEntity<DisputeProvisionalCredit>
    {
        /// <summary>
        /// The time by which the platform must grant a provisional credit to the consumer.
        /// </summary>
        [JsonProperty("grant_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("grant_deadline")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? GrantDeadline { get; set; }

        /// <summary>
        /// The time at which the platform reported granting the provisional credit.
        /// </summary>
        [JsonProperty("granted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("granted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? GrantedAt { get; set; }

        /// <summary>
        /// The earliest time after which the platform can revoke the provisional credit.
        /// </summary>
        [JsonProperty("revocable_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("revocable_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RevocableAfter { get; set; }

        /// <summary>
        /// The time at which the platform reported revoking the provisional credit.
        /// </summary>
        [JsonProperty("revoked_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("revoked_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RevokedAt { get; set; }

        /// <summary>
        /// The status of the provisional credit obligation.
        /// One of: <c>delinquent</c>, <c>granted</c>, <c>not_required</c>, <c>permanent</c>,
        /// <c>required</c>, <c>revocable</c>, <c>revocation_notice_period</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
