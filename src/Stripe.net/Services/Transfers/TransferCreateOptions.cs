// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in cents (or local equivalent) representing how much to transfer.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO code for
        /// currency</a> in lowercase. Must be a <a
        /// href="https://docs.stripe.com/currencies">supported currency</a>.
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
        /// The ID of a connected Stripe account. <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers">See the Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif
        public string Destination { get; set; }

        /// <summary>
        /// The FX rate in the quote is validated and used to convert the transfer amount to the
        /// destination currency.
        /// </summary>
        [JsonProperty("fx_quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_quote")]
#endif
        public string FxQuote { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
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
        /// You can use this parameter to transfer funds from a charge before they are added to your
        /// available balance. A pending balance will transfer immediately but the funds will not
        /// become available until the original charge becomes available. <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-availability">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("source_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_transaction")]
#endif
        public string SourceTransaction { get; set; }

        /// <summary>
        /// The source balance to use for this transfer. One of <c>bank_account</c>, <c>card</c>, or
        /// <c>fpx</c>. For most users, this will default to <c>card</c>.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonProperty("source_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_type")]
#endif
        public string SourceType { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif
        public string TransferGroup { get; set; }
    }
}
