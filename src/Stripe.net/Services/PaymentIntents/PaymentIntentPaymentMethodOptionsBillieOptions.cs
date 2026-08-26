// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsBillieOptions : INestedOptions, IHasSetTracking
    {
        private string captureMethod;
        private PaymentIntentPaymentMethodOptionsBillieCompanyDetailsOptions companyDetails;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Controls when the funds are captured from the customer's account.
        ///
        /// If provided, this parameter overrides the behavior of the top-level <a
        /// href="https://stripe.com/api/payment_intents/update#update_payment_intent-capture_method">capture_method</a>
        /// for this payment method type when finalizing the payment with this payment method type.
        ///
        /// If <c>capture_method</c> is already set on the PaymentIntent, providing an empty value
        /// for this parameter unsets the stored value for this payment method type.
        /// </summary>
        [JsonProperty("capture_method", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("capture_method")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CaptureMethod
        {
            get => this.captureMethod;
            set
            {
                this.captureMethod = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Registration details about the buyer's organization.
        /// </summary>
        [JsonProperty("company_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("company_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentMethodOptionsBillieCompanyDetailsOptions CompanyDetails
        {
            get => this.companyDetails;
            set
            {
                this.companyDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An identifier or reference that this payment corresponds to.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
