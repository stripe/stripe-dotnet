namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Mandate : StripeEntity<Mandate>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("customer_acceptance")]
        public MandateCustomerAcceptance CustomerAcceptance { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("multi_use")]
        public MandateMultiUse MultiUse { get; set; }

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the payment method associated with this mandate.
        /// </summary>
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment method associated with this mandate.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        [JsonProperty("payment_method_details")]
        public MandatePaymentMethodDetails PaymentMethodDetails { get; set; }

        [JsonProperty("single_use")]
        public MandateSingleUse SingleUse { get; set; }

        /// <summary>
        /// The status of the mandate, which indicates whether it can be used to initiate a payment.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of the mandate.
        /// One of: <c>multi_use</c>, or <c>single_use</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
