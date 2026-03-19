// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Invoice Payments represent payments made against invoices. Invoice Payments can be
    /// accessed in two ways: 1. By expanding the <c>payments</c> field on the <a
    /// href="https://api.stripe.com#invoice">Invoice</a> resource. 2. By using the Invoice
    /// Payment retrieve and list endpoints.
    ///
    /// Invoice Payments include the mapping between payment objects, such as Payment Intent,
    /// and Invoices. This resource and its endpoints allows you to easily track if a payment is
    /// associated with a specific invoice and monitor the allocation details of the payments.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePayment : StripeEntity<InvoicePayment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount that was actually paid for this invoice, in cents (or local equivalent). This
        /// field is null until the payment is <c>paid</c>. This amount can be less than the
        /// <c>amount_requested</c> if the PaymentIntent’s <c>amount_received</c> is not sufficient
        /// to pay all of the invoices that it is attached to.
        /// </summary>
        [JsonProperty("amount_paid")]
        [STJS.JsonPropertyName("amount_paid")]
        public long? AmountPaid { get; set; }

        /// <summary>
        /// Amount intended to be paid toward this invoice, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount_requested")]
        [STJS.JsonPropertyName("amount_requested")]
        public long AmountRequested { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// The invoice that was paid.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Stripe automatically creates a default InvoicePayment when the invoice is finalized, and
        /// keeps it synchronized with the invoice’s <c>amount_remaining</c>. The PaymentIntent
        /// associated with the default payment can’t be edited or canceled directly.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("payment")]
        [STJS.JsonPropertyName("payment")]
        public InvoicePaymentPayment Payment { get; set; }

        /// <summary>
        /// The status of the payment, one of <c>open</c>, <c>paid</c>, or <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public InvoicePaymentStatusTransitions StatusTransitions { get; set; }
    }
}
