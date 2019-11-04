namespace Stripe
{
    using System;
    using System.Collections.Generic;
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
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Details about the customer’s acceptance of the mandate.
        /// </summary>
        [JsonProperty("customer_acceptance")]
        public MandateCustomerAcceptance CustomerAcceptance { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// If this is a <c>multi_use</c> mandate, this hash contains details about the mandate.
        /// </summary>
        [JsonProperty("multi_use")]
        public MandateMultiUse MultiUse { get; set; }

        #region Expandable PaymentMethod

        /// <summary>
        /// ID of the payment method associated with this mandate.
        /// </summary>
        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

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

        /// <summary>
        /// Additional mandate information specific to the payment method type.
        /// </summary>
        [JsonProperty("payment_method_details")]
        public MandatePaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// If this is a <c>single_use</c> mandate, this hash contains details about the mandate.
        /// </summary>
        [JsonProperty("single_use")]
        public MandateSingleUse SingleUse { get; set; }

        /// <summary>
        /// The status of the Mandate. The Mandate can be used to initiate a payment if its status
        /// is <c>active</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of the mandate, one of <c>multi_use</c> or <c>single_use</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
