// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Represents a record from the card network of a money movement or change in state for an
    /// Issuing dispute. These records are included in the settlement reports that we receive
    /// from networks and expose to users as Settlement objects.
    /// </summary>
    public class DisputeSettlementDetail : StripeEntity<DisputeSettlementDetail>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Disputed amount in the card’s currency and in the smallest currency unit. Usually the
        /// amount of the transaction, but can differ (usually because of currency fluctuation).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// The card used to make the original transaction.
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
        /// The currency the original transaction was made in. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the linked dispute.
        /// </summary>
        [JsonProperty("dispute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute")]
#endif
        public string Dispute { get; set; }

        /// <summary>
        /// The type of event corresponding to this dispute settlement detail, representing the
        /// stage in the dispute network lifecycle.
        /// One of: <c>filing</c>, <c>loss</c>, <c>representment</c>, or <c>win</c>.
        /// </summary>
        [JsonProperty("event_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_type")]
#endif
        public string EventType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The card network for this dispute settlement detail. One of ["visa", "mastercard",
        /// "maestro"].
        /// One of: <c>maestro</c>, <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// The ID of the linked card network settlement.
        /// </summary>
        [JsonProperty("settlement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement")]
#endif
        public string Settlement { get; set; }
    }
}
