// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCashBalanceTransactionUnappliedFromPayment : StripeEntity<CustomerCashBalanceTransactionUnappliedFromPayment>
    {
        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The <a href="https://stripe.com/docs/api/payment_intents/object">Payment Intent</a> that
        /// funds were unapplied from.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://stripe.com/docs/api/payment_intents/object">Payment Intent</a> that
        /// funds were unapplied from.
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
    }
}
