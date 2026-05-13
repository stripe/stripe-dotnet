// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeEntryIncurredBy : StripeEntity<FeeEntryIncurredBy>, IHasId
    {
        /// <summary>
        /// The account that incurred the usage (may differ from the billing account).
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Public API object id, e.g. ch_xxx.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Timestamp of when the usage event occurred.
        /// </summary>
        [JsonProperty("occurred_at")]
        [STJS.JsonPropertyName("occurred_at")]
        public DateTime? OccurredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Public API object type: "charge", "payment", "refund", "dispute", "payout", etc.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
