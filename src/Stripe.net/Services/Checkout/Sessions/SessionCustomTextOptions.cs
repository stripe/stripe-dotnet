// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionCustomTextOptions : INestedOptions, IHasSetTracking
    {
        private SessionCustomTextAfterSubmitOptions afterSubmit;
        private SessionCustomTextShippingAddressOptions shippingAddress;
        private SessionCustomTextSubmitOptions submit;
        private SessionCustomTextTermsOfServiceAcceptanceOptions termsOfServiceAcceptance;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Custom text that should be displayed after the payment confirmation button.
        /// </summary>
        [JsonProperty("after_submit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("after_submit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SessionCustomTextAfterSubmitOptions AfterSubmit
        {
            get => this.afterSubmit;
            set
            {
                this.afterSubmit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Custom text that should be displayed alongside shipping address collection.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("shipping_address")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SessionCustomTextShippingAddressOptions ShippingAddress
        {
            get => this.shippingAddress;
            set
            {
                this.shippingAddress = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Custom text that should be displayed alongside the payment confirmation button.
        /// </summary>
        [JsonProperty("submit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("submit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SessionCustomTextSubmitOptions Submit
        {
            get => this.submit;
            set
            {
                this.submit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Custom text that should be displayed in place of the default terms of service agreement
        /// text.
        /// </summary>
        [JsonProperty("terms_of_service_acceptance", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("terms_of_service_acceptance")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SessionCustomTextTermsOfServiceAcceptanceOptions TermsOfServiceAcceptance
        {
            get => this.termsOfServiceAcceptance;
            set
            {
                this.termsOfServiceAcceptance = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
