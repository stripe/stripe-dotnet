namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PayoutCreateOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED. A positive integer in cents representing how much to payout.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// REQUIRED. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a
        /// <a href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users. This
        /// can be unset by updating the value to <c>null</c> and then saving.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of a bank account or a card to send the payout to. If no destination is
        /// supplied, the default external account for the specified currency will be used.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to a payout object. It can be useful for
        /// storing additional information about the payout in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The method used to send this payout, which can be <c>standard</c> or <c>instant</c>.
        /// <c>instant</c> is only supported for payouts to debit cards. (See
        /// <a href="https://stripe.com/blog/instant-payouts-for-marketplaces">Instant payouts for
        /// marketplaces for more information</a>.)
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// The source balance to draw this payout from. Balances for different payment sources are
        /// kept separately. You can find the amounts with the balances API. One of
        /// <c>bank_account</c> or <c>card</c>.
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// A string to be displayed on the recipient’s bank or card statement. This may be at most
        /// 22 characters. Attempting to use a <c>statement_descriptor</c> longer than 22
        /// characters will return an error. Note: Most banks will truncate this information and/or
        /// display it inconsistently. Some may not display it at all.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
