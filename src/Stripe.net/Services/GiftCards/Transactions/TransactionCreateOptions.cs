// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransactionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount of the transaction. A negative amount deducts funds, and a positive amount
        /// adds funds.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Whether this is a confirmed transaction. A confirmed transaction immediately deducts
        /// from/adds to the <c>amount_available</c> on the gift card. Otherwise, it creates a held
        /// transaction that increments the <c>amount_held</c> on the gift card.
        /// </summary>
        [JsonProperty("confirm")]
        public bool? Confirm { get; set; }

        /// <summary>
        /// Related objects which created this transaction.
        /// </summary>
        [JsonProperty("created_by")]
        public TransactionCreatedByOptions CreatedBy { get; set; }

        /// <summary>
        /// The currency of the transaction. This must match the currency of the gift card.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The gift card to create a new transaction on.
        /// </summary>
        [JsonProperty("gift_card")]
        public string GiftCard { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers">Connect documentation</a> for
        /// details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
