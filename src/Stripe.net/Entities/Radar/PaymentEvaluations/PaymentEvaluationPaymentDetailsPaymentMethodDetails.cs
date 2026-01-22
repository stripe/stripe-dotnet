// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PaymentEvaluationPaymentDetailsPaymentMethodDetails : StripeEntity<PaymentEvaluationPaymentDetailsPaymentMethodDetails>
    {
        /// <summary>
        /// Billing information associated with the payment evaluation.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public PaymentEvaluationPaymentDetailsPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// The payment method used in this payment evaluation.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// The payment method used in this payment evaluation.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
#endif
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion
    }
}
