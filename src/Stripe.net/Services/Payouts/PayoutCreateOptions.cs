// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PayoutCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in cents representing how much to payout.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of a bank account or a card to send the payout to. If you don't provide a
        /// destination, we use the default external account for the specified currency.
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
        /// The method used to send this payout, which is <c>standard</c> or <c>instant</c>. We
        /// support <c>instant</c> for payouts to debit cards and bank accounts in certain
        /// countries. Learn more about <a
        /// href="https://stripe.com/docs/payouts/instant-payouts-banks">bank support for Instant
        /// Payouts</a>.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// The balance type of your Stripe balance to draw this payout from. Balances for different
        /// payment sources are kept separately. You can find the amounts with the Balances API. One
        /// of <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// A string that displays on the recipient's bank or card statement (up to 22 characters).
        /// A <c>statement_descriptor</c> that's longer than 22 characters return an error. Most
        /// banks truncate this information and display it inconsistently. Some banks might not
        /// display it at all.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
