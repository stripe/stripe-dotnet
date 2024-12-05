// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReaderActionProcessPaymentIntent : StripeEntity<ReaderActionProcessPaymentIntent>
    {
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
        /// Represents a per-transaction override of a reader configuration.
        /// </summary>
        [JsonProperty("process_config")]
        public ReaderActionProcessPaymentIntentProcessConfig ProcessConfig { get; set; }

        [JsonProperty("stripe_account")]
        public string StripeAccount { get; set; }
    }
}
