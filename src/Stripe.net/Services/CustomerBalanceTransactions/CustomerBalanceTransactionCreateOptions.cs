namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CustomerBalanceTransactionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in <strong>%s</strong> to apply to the customer's balance. Pass a
        /// negative amount to credit the customer's balance, and pass in a positive amount to debit
        /// the customer's balance.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>. If the customer's <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-currency"><c>currency</c></a>
        /// is set, this value must match it. If the customer's <c>currency</c> is not set, it will
        /// be updated to this value.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
