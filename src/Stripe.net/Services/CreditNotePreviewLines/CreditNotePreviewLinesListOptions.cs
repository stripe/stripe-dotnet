// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditNotePreviewLinesListOptions : ListOptions, IHasMetadata
    {
        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount to credit the
        /// customer's balance, which will be automatically applied to their next invoice.
        /// </summary>
        [JsonProperty("credit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_amount")]
#endif

        public long? CreditAmount { get; set; }

        /// <summary>
        /// The date when this credit note is in effect. Same as <c>created</c> unless overwritten.
        /// When defined, this value replaces the system-generated 'Date of issue' printed on the
        /// credit note PDF.
        /// </summary>
        [JsonProperty("effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// Type of email to send to the customer, one of <c>credit_note</c> or <c>none</c> and the
        /// default is <c>credit_note</c>.
        /// One of: <c>credit_note</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("email_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email_type")]
#endif

        public string EmailType { get; set; }

        /// <summary>
        /// ID of the invoice.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif

        public string Invoice { get; set; }

        /// <summary>
        /// Line items that make up the credit note.
        /// </summary>
        [JsonProperty("lines")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lines")]
#endif

        public List<CreditNotePreviewLinesLineOptions> Lines { get; set; }

        /// <summary>
        /// The credit note's memo appears on the credit note PDF.
        /// </summary>
        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif

        public string Memo { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
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
        /// The integer amount in cents (or local equivalent) representing the amount that is
        /// credited outside of Stripe.
        /// </summary>
        [JsonProperty("out_of_band_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("out_of_band_amount")]
#endif

        public long? OutOfBandAmount { get; set; }

        /// <summary>
        /// Reason for issuing this credit note, one of <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>order_change</c>, or <c>product_unsatisfactory</c>.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>order_change</c>, or
        /// <c>product_unsatisfactory</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif

        public string Reason { get; set; }

        /// <summary>
        /// ID of an existing refund to link this credit note to.
        /// </summary>
        [JsonProperty("refund")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund")]
#endif

        public string Refund { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount to refund. If
        /// set, a refund will be created for the charge associated with the invoice.
        /// </summary>
        [JsonProperty("refund_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_amount")]
#endif

        public long? RefundAmount { get; set; }

        /// <summary>
        /// When shipping_cost contains the shipping_rate from the invoice, the shipping_cost is
        /// included in the credit note.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif

        public CreditNotePreviewLinesShippingCostOptions ShippingCost { get; set; }
    }
}
