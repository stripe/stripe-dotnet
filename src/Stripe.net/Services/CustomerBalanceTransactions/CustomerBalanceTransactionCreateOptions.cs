// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerBalanceTransactionCreateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// The integer amount in <strong>cents (or local equivalent)</strong> to apply to the
        /// customer's credit balance.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Required when <c>type</c> is <c>applied_to_invoice</c>. Identifies the open invoice to
        /// apply the customer's balance credit to.
        /// </summary>
        [JsonProperty("applied_to_invoice")]
        [STJS.JsonPropertyName("applied_to_invoice")]
        public CustomerBalanceTransactionAppliedToInvoiceOptions AppliedToInvoice { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>. Specifies the <a
        /// href="https://docs.stripe.com/api/customers/object#customer_object-invoice_credit_balance"><c>invoice_credit_balance</c></a>
        /// that this transaction will apply to. If the customer's <c>currency</c> is not set, it
        /// will be updated to this value.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The type of customer balance transaction. Defaults to <c>adjustment</c>, which updates
        /// the customer's credit balance directly. Set to <c>applied_to_invoice</c> to apply the
        /// customer's existing credit balance to a specific open invoice.
        /// One of: <c>adjustment</c>, or <c>applied_to_invoice</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
