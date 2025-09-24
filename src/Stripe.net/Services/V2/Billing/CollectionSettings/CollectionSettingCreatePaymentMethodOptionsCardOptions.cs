// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CollectionSettingCreatePaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Configuration options for setting up an eMandate for cards issued in India.
        /// </summary>
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public CollectionSettingCreatePaymentMethodOptionsCardMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// Selected network to process the payment on. Depends on the available networks of the
        /// card.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// An advanced option 3D Secure. We strongly recommend that you rely on our SCA Engine to
        /// automatically prompt your customers for authentication based on risk level and <a
        /// href="https://docs.corp.stripe.com/strong-customer-authentication">other
        /// requirements</a>. However, if you wish to request 3D Secure based on logic from your own
        /// fraud engine, provide this option. Read our guide on <a
        /// href="https://docs.corp.stripe.com/payments/3d-secure/authentication-flow#manual-three-ds">manually
        /// requesting 3D Secure</a> for more information on how this configuration interacts with
        /// Radar and our SCA Engine.
        /// One of: <c>any</c>, <c>automatic</c>, or <c>challenge</c>.
        /// </summary>
        [JsonProperty("request_three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_three_d_secure")]
#endif
        public string RequestThreeDSecure { get; set; }
    }
}
