// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomTextOptions : INestedOptions
    {
        /// <summary>
        /// Custom text that should be displayed after the payment confirmation button.
        /// </summary>
        [JsonProperty("after_submit")]
        public SessionCustomTextAfterSubmitOptions AfterSubmit { get; set; }

        /// <summary>
        /// Custom text that should be displayed alongside shipping address collection.
        /// </summary>
        [JsonProperty("shipping_address")]
        public SessionCustomTextShippingAddressOptions ShippingAddress { get; set; }

        /// <summary>
        /// Custom text that should be displayed alongside the payment confirmation button.
        /// </summary>
        [JsonProperty("submit")]
        public SessionCustomTextSubmitOptions Submit { get; set; }

        /// <summary>
        /// Custom text that should be displayed in place of the default terms of service agreement
        /// text.
        /// </summary>
        [JsonProperty("terms_of_service_acceptance")]
        public SessionCustomTextTermsOfServiceAcceptanceOptions TermsOfServiceAcceptance { get; set; }
    }
}
