// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCardGeneratedFrom : StripeEntity<PaymentMethodCardGeneratedFrom>
    {
        /// <summary>
        /// The charge that created this object.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Transaction-specific details of the payment method used in the payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        public PaymentMethodCardGeneratedFromPaymentMethodDetails PaymentMethodDetails { get; set; }

        #region Expandable SetupAttempt

        /// <summary>
        /// (ID of the SetupAttempt)
        /// The ID of the SetupAttempt that generated this PaymentMethod, if any.
        /// </summary>
        [JsonIgnore]
        public string SetupAttemptId
        {
            get => this.InternalSetupAttempt?.Id;
            set => this.InternalSetupAttempt = SetExpandableFieldId(value, this.InternalSetupAttempt);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SetupAttempt that generated this PaymentMethod, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public SetupAttempt SetupAttempt
        {
            get => this.InternalSetupAttempt?.ExpandedObject;
            set => this.InternalSetupAttempt = SetExpandableFieldObject(value, this.InternalSetupAttempt);
        }

        [JsonProperty("setup_attempt")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupAttempt>))]
        internal ExpandableField<SetupAttempt> InternalSetupAttempt { get; set; }
        #endregion
    }
}
