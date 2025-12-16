// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class ReaderActionCollectPaymentMethod : StripeEntity<ReaderActionCollectPaymentMethod>
    {
        /// <summary>
        /// Represents a per-transaction override of a reader configuration.
        /// </summary>
        [JsonProperty("collect_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collect_config")]
#endif
        public ReaderActionCollectPaymentMethodCollectConfig CollectConfig { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// Most recent PaymentIntent processed by the reader.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// PaymentMethod objects represent your customer's payment instruments. You can use them
        /// with <a href="https://docs.stripe.com/payments/payment-intents">PaymentIntents</a> to
        /// collect payments or save them to Customer objects to store instrument details for future
        /// payments.
        ///
        /// Related guides: <a href="https://docs.stripe.com/payments/payment-methods">Payment
        /// Methods</a> and <a href="https://docs.stripe.com/payments/more-payment-scenarios">More
        /// Payment Scenarios</a>.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public PaymentMethod PaymentMethod { get; set; }
    }
}
