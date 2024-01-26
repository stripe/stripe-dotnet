// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransactionLineItem : StripeEntity<TransactionLineItem>, IHasId, IHasMetadata, IHasObject
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
        /// The line item amount in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>. If
        /// <c>tax_behavior=inclusive</c>, then this amount includes taxes. Otherwise, taxes were
        /// calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The amount of tax calculated for this line item, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of an existing <a href="https://stripe.com/docs/api/products/object">Product</a>.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The number of units of the item being purchased. For reversals, this is the quantity
        /// reversed.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item in the transaction.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// If <c>type=reversal</c>, contains information about what was reversed.
        /// </summary>
        [JsonProperty("reversal")]
        public TransactionLineItemReversal Reversal { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. If <c>tax_behavior=inclusive</c>,
        /// then the amount includes taxes.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID used for this
        /// resource.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// If <c>reversal</c>, this line item reverses an earlier transaction.
        /// One of: <c>reversal</c>, or <c>transaction</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
