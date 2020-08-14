namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in %s representing how much to transfer.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 3-letter <a href="https://stripe.com/docs/payouts">ISO code for currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of a connected Stripe account. &lt;a
        /// href="/docs/connect/charges-transfers"&gt;See the Connect documentation&lt;/a&gt; for
        /// details.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// You can use this parameter to transfer funds from a charge before they are added to your
        /// available balance. A pending balance will transfer immediately but the funds will not
        /// become available until the original charge becomes available. <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-availability">See the
        /// Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("source_transaction")]
        public string SourceTransaction { get; set; }

        /// <summary>
        /// The source balance to use for this transfer. One of <c>bank_account</c>, <c>card</c>, or
        /// <c>fpx</c>. For most users, this will default to <c>card</c>.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
