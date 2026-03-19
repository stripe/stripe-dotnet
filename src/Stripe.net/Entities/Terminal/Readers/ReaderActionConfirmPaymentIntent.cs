// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionConfirmPaymentIntent : StripeEntity<ReaderActionConfirmPaymentIntent>
    {
        /// <summary>
        /// Account the payment intent belongs to.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// Represents a per-transaction override of a reader configuration.
        /// </summary>
        [JsonProperty("confirm_config")]
        [STJS.JsonPropertyName("confirm_config")]
        public ReaderActionConfirmPaymentIntentConfirmConfig ConfirmConfig { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// Most recent PaymentIntent processed by the reader.
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
        /// Most recent PaymentIntent processed by the reader.
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
