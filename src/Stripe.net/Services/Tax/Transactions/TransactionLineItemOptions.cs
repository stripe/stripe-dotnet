// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionLineItemOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The amount to reverse, in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of tax to reverse, in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long? AmountTax { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The <c>id</c> of the line item to reverse in the original transaction.
        /// </summary>
        [JsonProperty("original_line_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_line_item")]
#endif
        public string OriginalLineItem { get; set; }

        /// <summary>
        /// The quantity reversed. Appears in <a href="https://docs.stripe.com/tax/reports">tax
        /// exports</a>, but does not affect the amount of tax reversed.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item in the reversal transaction, such as 'L1-refund'.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
