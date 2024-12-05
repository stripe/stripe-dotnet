// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReaderActionCollectPaymentMethod : StripeEntity<ReaderActionCollectPaymentMethod>
    {
        /// <summary>
        /// Represents a per-transaction override of a reader configuration.
        /// </summary>
        [JsonProperty("collect_config")]
        public ReaderActionCollectPaymentMethodCollectConfig CollectConfig { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// Most recent PaymentIntent processed by the reader.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// Most recent PaymentIntent processed by the reader.
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
        /// PaymentMethod objects represent your customer's payment instruments. You can use them
        /// with <a href="https://stripe.com/docs/payments/payment-intents">PaymentIntents</a> to
        /// collect payments or save them to Customer objects to store instrument details for future
        /// payments.
        ///
        /// Related guides: <a href="https://stripe.com/docs/payments/payment-methods">Payment
        /// Methods</a> and <a href="https://stripe.com/docs/payments/more-payment-scenarios">More
        /// Payment Scenarios</a>.
        /// </summary>
        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonProperty("stripe_account")]
        public string StripeAccount { get; set; }
    }
}
