// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransactionLineItemOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The amount to reverse, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of tax to reverse, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long? AmountTax { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The <c>id</c> of the line item to reverse in the original transaction.
        /// </summary>
        [JsonProperty("original_line_item")]
        public string OriginalLineItem { get; set; }

        /// <summary>
        /// The quantity reversed. Appears in <a href="https://stripe.com/docs/tax/reports">tax
        /// exports</a>, but does not affect the amount of tax reversed.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item in the reversal transaction, such as 'L1-refund'.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
