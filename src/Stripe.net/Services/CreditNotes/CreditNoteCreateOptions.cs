namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditNoteCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the total amount of the credit
        /// note.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the amount to credit the
        /// customer's balance, which will be automatically applied to their next invoice.
        /// </summary>
        [JsonProperty("credit_amount")]
        public long? CreditAmount { get; set; }

        /// <summary>
        /// ID of the invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// Line items that make up the credit note.
        /// </summary>
        [JsonProperty("lines")]
        public List<CreditNoteLineOptions> Lines { get; set; }

        /// <summary>
        /// The credit note's memo appears on the credit note PDF.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the amount that is credited
        /// outside of Stripe.
        /// </summary>
        [JsonProperty("out_of_band_amount")]
        public long? OutOfBandAmount { get; set; }

        /// <summary>
        /// Reason for issuing this credit note, one of <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>order_change</c>, or <c>product_unsatisfactory</c>.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>order_change</c>, or
        /// <c>product_unsatisfactory</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// ID of an existing refund to link this credit note to.
        /// </summary>
        [JsonProperty("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// The integer amount in <strong>%s</strong> representing the amount to refund. If set, a
        /// refund will be created for the charge associated with the invoice.
        /// </summary>
        [JsonProperty("refund_amount")]
        public long? RefundAmount { get; set; }
    }
}
