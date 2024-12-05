// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/customers/object">Customer</a> used for the resource.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public TransactionCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// The tax collected or refunded, by line item.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public StripeList<TransactionLineItem> LineItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

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
        /// The Unix timestamp representing when the tax liability is assumed or reduced.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime PostedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A custom unique identifier, such as 'myOrder_123'.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// If <c>type=reversal</c>, contains information about what was reversed.
        /// </summary>
        [JsonProperty("reversal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversal")]
#endif
        public TransactionReversal Reversal { get; set; }

        /// <summary>
        /// The details of the ship from location, such as the address.
        /// </summary>
        [JsonProperty("ship_from_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ship_from_details")]
#endif
        public TransactionShipFromDetails ShipFromDetails { get; set; }

        /// <summary>
        /// The shipping cost details for the transaction.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif
        public TransactionShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime TaxDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If <c>reversal</c>, this transaction reverses an earlier transaction.
        /// One of: <c>reversal</c>, or <c>transaction</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
