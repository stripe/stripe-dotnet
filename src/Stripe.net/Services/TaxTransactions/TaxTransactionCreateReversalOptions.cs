// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaxTransactionCreateReversalOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The line item amounts to reverse.
        /// </summary>
        [JsonProperty("line_items")]
        public List<TaxTransactionLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If <c>partial</c>, the provided line item amounts are reversed. If <c>full</c>, the
        /// original transaction is fully reversed.
        /// One of: <c>full</c>, or <c>partial</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The ID of the transaction to partially or fully reverse.
        /// </summary>
        [JsonProperty("original_transaction")]
        public string OriginalTransaction { get; set; }

        /// <summary>
        /// A custom identifier for this reversal, such as 'myOrder_123-refund_1'. Must be unique
        /// across all transactions.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
