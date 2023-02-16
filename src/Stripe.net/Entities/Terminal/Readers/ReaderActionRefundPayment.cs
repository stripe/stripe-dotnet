// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReaderActionRefundPayment : StripeEntity<ReaderActionRefundPayment>, IHasMetadata
    {
        /// <summary>
        /// The amount being refunded.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// Charge that is being refunded.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// Charge that is being refunded.
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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// Payment intent that is being refunded.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// Payment intent that is being refunded.
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
        /// The reason for the refund.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, or <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        #region Expandable Refund

        /// <summary>
        /// (ID of the Refund)
        /// Unique identifier for the refund object.
        /// </summary>
        [JsonIgnore]
        public string RefundId
        {
            get => this.InternalRefund?.Id;
            set => this.InternalRefund = SetExpandableFieldId(value, this.InternalRefund);
        }

        /// <summary>
        /// (Expanded)
        /// Unique identifier for the refund object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Refund Refund
        {
            get => this.InternalRefund?.ExpandedObject;
            set => this.InternalRefund = SetExpandableFieldObject(value, this.InternalRefund);
        }

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when refunding this
        /// charge. If a full charge refund is given, the full application fee will be refunded.
        /// Otherwise, the application fee will be refunded in an amount proportional to the amount
        /// of the charge refunded. An application fee can be refunded only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("refund_application_fee")]
        public bool RefundApplicationFee { get; set; }

        /// <summary>
        /// Boolean indicating whether the transfer should be reversed when refunding this charge.
        /// The transfer will be reversed proportionally to the amount being refunded (either the
        /// entire or partial amount). A transfer can be reversed only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("reverse_transfer")]
        public bool ReverseTransfer { get; set; }
    }
}
