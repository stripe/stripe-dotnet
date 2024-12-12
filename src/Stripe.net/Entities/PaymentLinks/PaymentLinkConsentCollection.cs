// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkConsentCollection : StripeEntity<PaymentLinkConsentCollection>
    {
        /// <summary>
        /// Settings related to the payment method reuse text shown in the Checkout UI.
        /// </summary>
        [JsonProperty("payment_method_reuse_agreement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_reuse_agreement")]
#endif
        public PaymentLinkConsentCollectionPaymentMethodReuseAgreement PaymentMethodReuseAgreement { get; set; }

        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications.
        /// One of: <c>auto</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("promotions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotions")]
#endif
        public string Promotions { get; set; }

        /// <summary>
        /// If set to <c>required</c>, it requires cutomers to accept the terms of service before
        /// being able to pay. If set to <c>none</c>, customers won't be shown a checkbox to accept
        /// the terms of service.
        /// One of: <c>none</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service")]
#endif
        public string TermsOfService { get; set; }
    }
}
