// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A FeeEntry is the atomic, append-only record of an assessed fee.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeEntry : StripeEntity<FeeEntry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the FeeEntry.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The fee amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The entity that assessed this fee.
        /// </summary>
        [JsonProperty("charged_by")]
        [STJS.JsonPropertyName("charged_by")]
        public FeeEntryChargedBy ChargedBy { get; set; }

        /// <summary>
        /// Timestamp of when this fee entry was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the FeeBatch that collected this fee, if any.
        /// </summary>
        [JsonProperty("fee_batch")]
        [STJS.JsonPropertyName("fee_batch")]
        public string FeeBatch { get; set; }

        /// <summary>
        /// The usage event that caused this fee to be assessed.
        /// </summary>
        [JsonProperty("incurred_by")]
        [STJS.JsonPropertyName("incurred_by")]
        public FeeEntryIncurredBy IncurredBy { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode, or <c>false</c> if in test
        /// mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The reason this fee entry was created.
        /// One of: <c>other</c>, <c>processing_fee</c>, <c>refund</c>, <c>refund_failure</c>,
        /// <c>reprice</c>, or <c>tier_true_up</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The tax portion of the fee, if applicable.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public FeeEntryTax Tax { get; set; }

        /// <summary>
        /// The category of this fee.
        /// One of: <c>application_fee</c>, <c>passthrough_fee</c>, or <c>stripe_fee</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
