// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Disputed amount in the card’s currency and in the smallest currency unit. Usually the
        /// amount of the transaction, but can differ (usually because of currency fluctuation).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The card used to make the original transaction.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The currency the original transaction was made in. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the linked dispute.
        /// </summary>
        [JsonProperty("dispute")]
        public string Dispute { get; set; }

        /// <summary>
        /// The type of event corresponding to this dispute settlement detail, representing the
        /// stage in the dispute network lifecycle.
        /// One of: <c>filing</c>, <c>loss</c>, <c>representment</c>, or <c>win</c>.
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The card network for this dispute settlement detail. One of ["visa", "mastercard",
        /// "maestro"].
        /// One of: <c>maestro</c>, <c>mastercard</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// The ID of the linked card network settlement.
        /// </summary>
        [JsonProperty("settlement")]
        public string Settlement { get; set; }
    }
}
