// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A gift card transaction represents a single transaction on a referenced gift card. A
    /// transaction is in one of three states, <c>confirmed</c>, <c>held</c> or <c>canceled</c>.
    /// A <c>confirmed</c> transaction is one that has added/deducted funds. A <c>held</c>
    /// transaction has created a temporary hold on funds, which can then be cancelled or
    /// confirmed. A <c>held</c> transaction can be confirmed into a <c>confirmed</c>
    /// transaction, or canceled into a <c>canceled</c> transaction. A <c>canceled</c>
    /// transaction has no effect on a gift card's balance.
    /// </summary>
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject
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
        /// The amount of this transaction. A positive value indicates that funds were added to the
        /// gift card. A negative value indicates that funds were removed from the gift card.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Time at which the transaction was confirmed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("confirmed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ConfirmedAt { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Created { get; set; }

        /// <summary>
        /// The related Stripe objects that created this gift card transaction.
        /// </summary>
        [JsonProperty("created_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_by")]
#endif
        public TransactionCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The gift card that this transaction occurred on.
        /// </summary>
        [JsonProperty("gift_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gift_card")]
#endif
        public string GiftCard { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Status of this transaction, one of <c>held</c>, <c>confirmed</c>, or <c>canceled</c>.
        /// One of: <c>canceled</c>, <c>confirmed</c>, <c>held</c>, or <c>invalid</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif
        public string TransferGroup { get; set; }
    }
}
