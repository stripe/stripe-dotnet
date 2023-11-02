// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// The invoice payment object.
    /// </summary>
    public class InvoicePayment : StripeEntity<InvoicePayment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Excess payment that was received for this invoice and credited to the customer’s
        /// <c>invoice_credit_balance</c>. This field is null until the payment is <c>paid</c>.
        /// Overpayment can happen when you attach more than one PaymentIntent to the invoice, and
        /// each of them succeeds. To avoid overpayment, cancel any PaymentIntents that you do not
        /// need before attaching more.
        /// </summary>
        [JsonProperty("amount_overpaid")]
        public long? AmountOverpaid { get; set; }

        /// <summary>
        /// Amount that was actually paid for this invoice, in cents (or local equivalent). This
        /// field is null until the payment is <c>paid</c>. This amount can be less than the
        /// <c>amount_requested</c> if the PaymentIntent’s <c>amount_received</c> is not sufficient
        /// to pay all of the invoices that it is attached to.
        /// </summary>
        [JsonProperty("amount_paid")]
        public long? AmountPaid { get; set; }

        /// <summary>
        /// Amount intended to be paid toward this invoice, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_requested")]
        public long AmountRequested { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the successful charge for this payment. This field is null when the payment is
        /// <c>open</c> or <c>canceled</c>.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the successful charge for this payment. This field is null when the payment is
        /// <c>open</c> or <c>canceled</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The invoice that was paid.
        /// </summary>
        [JsonIgnore]
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
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Stripe automatically creates a default InvoicePayment when the invoice is finalized, and
        /// keeps it synchronized with the invoice’s <c>amount_remaining</c>. The PaymentIntent
        /// associated with the default payment can’t be edited or canceled directly.
        /// </summary>
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent associated with this payment. Note: This property is only
        /// populated for invoices finalized on or after March 15th, 2019.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent associated with this payment. Note: This property is only
        /// populated for invoices finalized on or after March 15th, 2019.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// The status of the payment, one of <c>open</c>, <c>paid</c>, or <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public InvoicePaymentStatusTransitions StatusTransitions { get; set; }
    }
}
