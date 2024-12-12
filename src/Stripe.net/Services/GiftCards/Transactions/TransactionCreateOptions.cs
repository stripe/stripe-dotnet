// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount of the transaction. A negative amount deducts funds, and a positive amount
        /// adds funds.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Whether this is a confirmed transaction. A confirmed transaction immediately deducts
        /// from/adds to the <c>amount_available</c> on the gift card. Otherwise, it creates a held
        /// transaction that increments the <c>amount_held</c> on the gift card.
        /// </summary>
        [JsonProperty("confirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirm")]
#endif
        public bool? Confirm { get; set; }

        /// <summary>
        /// Related objects which created this transaction.
        /// </summary>
        [JsonProperty("created_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_by")]
#endif
        public TransactionCreatedByOptions CreatedBy { get; set; }

        /// <summary>
        /// The currency of the transaction. This must match the currency of the gift card.
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
        /// The gift card to create a new transaction on.
        /// </summary>
        [JsonProperty("gift_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gift_card")]
#endif
        public string GiftCard { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

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
