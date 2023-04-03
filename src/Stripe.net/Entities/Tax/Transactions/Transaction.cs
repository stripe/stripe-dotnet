// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Tax Transaction records the tax collected from or refunded to your customer.
    ///
    /// Related guide: <a href="https://stripe.com/docs/tax/custom#tax-transaction">Calculate
    /// tax in your custom payment flow</a>.
    /// </summary>
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the transaction.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/customers/object">Customer</a> used for the resource.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("customer_details")]
        public TransactionCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// The tax collected or refunded, by line item.
        /// </summary>
        [JsonProperty("line_items")]
        public StripeList<TransactionLineItem> LineItems { get; set; }

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
        /// A custom unique identifier, such as 'myOrder_123'.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// If <c>type=reversal</c>, contains information about what was reversed.
        /// </summary>
        [JsonProperty("reversal")]
        public TransactionReversal Reversal { get; set; }

        /// <summary>
        /// The shipping cost details for the transaction.
        /// </summary>
        [JsonProperty("shipping_cost")]
        public TransactionShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime TaxDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If <c>reversal</c>, this transaction reverses an earlier transaction.
        /// One of: <c>reversal</c>, or <c>transaction</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
