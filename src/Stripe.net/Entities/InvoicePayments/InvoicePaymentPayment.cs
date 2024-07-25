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

        [JsonProperty("out_of_band_payment")]
        public InvoicePaymentPaymentOutOfBandPayment OutOfBandPayment { get; set; }

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

        /// <summary>
        /// Type of payment object associated with this invoice payment.
        /// One of: <c>charge</c>, <c>out_of_band_payment</c>, or <c>payment_intent</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
