// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderPayment : StripeEntity<OrderPayment>
    {
        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the payment intent associated with this order. Null when the order is <c>open</c>.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment intent associated with this order. Null when the order is <c>open</c>.
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
        /// Settings describing how the order should configure generated PaymentIntents.
        /// </summary>
        [JsonProperty("settings")]
        public OrderPaymentSettings Settings { get; set; }

        /// <summary>
        /// The status of the underlying payment associated with this order, if any. Null when the
        /// order is <c>open</c>.
        /// One of: <c>canceled</c>, <c>complete</c>, <c>not_required</c>, <c>processing</c>,
        /// <c>requires_action</c>, <c>requires_capture</c>, <c>requires_confirmation</c>, or
        /// <c>requires_payment_method</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
