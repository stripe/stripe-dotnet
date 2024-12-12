// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkCustomTextOptions : INestedOptions
    {
        /// <summary>
        /// Custom text that should be displayed after the payment confirmation button.
        /// </summary>
        [JsonProperty("after_submit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("after_submit")]
#endif
        public PaymentLinkCustomTextAfterSubmitOptions AfterSubmit { get; set; }

        /// <summary>
        /// Custom text that should be displayed alongside shipping address collection.
        /// </summary>
        [JsonProperty("shipping_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address")]
#endif
        public PaymentLinkCustomTextShippingAddressOptions ShippingAddress { get; set; }

        /// <summary>
        /// Custom text that should be displayed alongside the payment confirmation button.
        /// </summary>
        [JsonProperty("submit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submit")]
#endif
        public PaymentLinkCustomTextSubmitOptions Submit { get; set; }

        /// <summary>
        /// Custom text that should be displayed in place of the default terms of service agreement
        /// text.
        /// </summary>
        [JsonProperty("terms_of_service_acceptance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service_acceptance")]
#endif
        public PaymentLinkCustomTextTermsOfServiceAcceptanceOptions TermsOfServiceAcceptance { get; set; }
    }
}
