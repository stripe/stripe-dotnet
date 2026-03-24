// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkCustomTextOptions : INestedOptions, IHasSetTracking
    {
        private PaymentLinkCustomTextAfterSubmitOptions afterSubmit;
        private PaymentLinkCustomTextShippingAddressOptions shippingAddress;
        private PaymentLinkCustomTextSubmitOptions submit;
        private PaymentLinkCustomTextTermsOfServiceAcceptanceOptions termsOfServiceAcceptance;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Custom text that should be displayed after the payment confirmation button.
        /// </summary>
        [JsonProperty("after_submit")]
        [STJS.JsonPropertyName("after_submit")]
        public PaymentLinkCustomTextAfterSubmitOptions AfterSubmit
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
        public PaymentLinkCustomTextShippingAddressOptions ShippingAddress
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
        public PaymentLinkCustomTextSubmitOptions Submit
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
        public PaymentLinkCustomTextTermsOfServiceAcceptanceOptions TermsOfServiceAcceptance
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
