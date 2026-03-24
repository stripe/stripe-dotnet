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
        [JsonProperty("after_submit")]
        [STJS.JsonPropertyName("after_submit")]
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
        [JsonProperty("shipping_address")]
        [STJS.JsonPropertyName("shipping_address")]
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
        [JsonProperty("submit")]
        [STJS.JsonPropertyName("submit")]
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
        [JsonProperty("terms_of_service_acceptance")]
        [STJS.JsonPropertyName("terms_of_service_acceptance")]
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
