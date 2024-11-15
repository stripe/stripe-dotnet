// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionCreateReversalOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A flat amount to reverse across the entire transaction, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative. This value represents the total amount to refund from the transaction,
        /// including taxes.
        /// </summary>
        [JsonProperty("flat_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flat_amount")]
#endif

        public long? FlatAmount { get; set; }

        /// <summary>
        /// The line item amounts to reverse.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif

        public List<TransactionLineItemOptions> LineItems { get; set; }

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
        /// If <c>partial</c>, the provided line item or shipping cost amounts are reversed. If
        /// <c>full</c>, the original transaction is fully reversed.
        /// One of: <c>full</c>, or <c>partial</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif

        public string Mode { get; set; }

        /// <summary>
        /// The ID of the Transaction to partially or fully reverse.
        /// </summary>
        [JsonProperty("original_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_transaction")]
#endif

        public string OriginalTransaction { get; set; }

        /// <summary>
        /// A custom identifier for this reversal, such as <c>myOrder_123-refund_1</c>, which must
        /// be unique across all transactions. The reference helps identify this reversal
        /// transaction in exported <a href="https://stripe.com/docs/tax/reports">tax reports</a>.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif

        public string Reference { get; set; }

        /// <summary>
        /// The shipping cost to reverse.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif

        public TransactionShippingCostOptions ShippingCost { get; set; }
    }
}
