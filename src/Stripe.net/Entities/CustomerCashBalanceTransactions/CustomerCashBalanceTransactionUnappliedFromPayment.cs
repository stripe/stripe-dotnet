// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerCashBalanceTransactionUnappliedFromPayment : StripeEntity<CustomerCashBalanceTransactionUnappliedFromPayment>
    {
        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// The <a href="https://docs.stripe.com/api/payment_intents/object">Payment Intent</a> that
        /// funds were unapplied from.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// The <a href="https://docs.stripe.com/api/payment_intents/object">Payment Intent</a> that
        /// funds were unapplied from.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion
    }
}
