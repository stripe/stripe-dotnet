// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The invoice payment object.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class InvoicePayment : StripeEntity<InvoicePayment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// Excess payment that was received for this invoice and credited to the customer’s
        /// <c>invoice_credit_balance</c>. This field is null until the payment is <c>paid</c>.
        /// Overpayment can happen when you attach more than one PaymentIntent to the invoice, and
        /// each of them succeeds. To avoid overpayment, cancel any PaymentIntents that you do not
        /// need before attaching more.
        /// </summary>
        [JsonProperty("amount_overpaid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_overpaid")]
#endif
        public long? AmountOverpaid { get; set; }

        /// <summary>
        /// Amount that was actually paid for this invoice, in cents (or local equivalent). This
        /// field is null until the payment is <c>paid</c>. This amount can be less than the
        /// <c>amount_requested</c> if the PaymentIntent’s <c>amount_received</c> is not sufficient
        /// to pay all of the invoices that it is attached to.
        /// </summary>
        [JsonProperty("amount_paid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_paid")]
#endif
        public long? AmountPaid { get; set; }

        /// <summary>
        /// Amount intended to be paid toward this invoice, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public long AmountRequested { get; set; }

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

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The invoice that was paid.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// The invoice that was paid.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
#endif
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Stripe automatically creates a default InvoicePayment when the invoice is finalized, and
        /// keeps it synchronized with the invoice’s <c>amount_remaining</c>. The PaymentIntent
        /// associated with the default payment can’t be edited or canceled directly.
        /// </summary>
        [JsonProperty("is_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_default")]
#endif
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public InvoicePaymentPayment Payment { get; set; }

        /// <summary>
        /// The status of the payment, one of <c>open</c>, <c>paid</c>, or <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public InvoicePaymentStatusTransitions StatusTransitions { get; set; }
    }
}
