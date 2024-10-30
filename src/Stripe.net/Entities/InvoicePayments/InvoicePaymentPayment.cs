// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoicePaymentPayment : StripeEntity<InvoicePaymentPayment>
    {
        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the successful charge for this payment when <c>type</c> is <c>charge</c>.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the successful charge for this payment when <c>type</c> is <c>charge</c>.
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

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent associated with this payment when <c>type</c> is
        /// <c>payment_intent</c>. Note: This property is only populated for invoices finalized on
        /// or after March 15th, 2019.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent associated with this payment when <c>type</c> is
        /// <c>payment_intent</c>. Note: This property is only populated for invoices finalized on
        /// or after March 15th, 2019.
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

        #region Expandable PaymentRecord

        /// <summary>
        /// (ID of the PaymentRecord)
        /// ID of the PaymentRecord associated with this payment when <c>type</c> is
        /// <c>payment_record</c>.
        /// </summary>
        [JsonIgnore]
        public string PaymentRecordId
        {
            get => this.InternalPaymentRecord?.Id;
            set => this.InternalPaymentRecord = SetExpandableFieldId(value, this.InternalPaymentRecord);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentRecord associated with this payment when <c>type</c> is
        /// <c>payment_record</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentRecord PaymentRecord
        {
            get => this.InternalPaymentRecord?.ExpandedObject;
            set => this.InternalPaymentRecord = SetExpandableFieldObject(value, this.InternalPaymentRecord);
        }

        [JsonProperty("payment_record")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentRecord>))]
        internal ExpandableField<PaymentRecord> InternalPaymentRecord { get; set; }
        #endregion

        /// <summary>
        /// Type of payment object associated with this invoice payment.
        /// One of: <c>charge</c>, <c>out_of_band_payment</c>, <c>payment_intent</c>, or
        /// <c>payment_record</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
