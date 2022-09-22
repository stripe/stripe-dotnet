// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkConsentCollection : StripeEntity<PaymentLinkConsentCollection>
    {
        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications.
        /// One of: <c>auto</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("promotions")]
        public string Promotions { get; set; }

        /// <summary>
        /// If set to <c>required</c>, it requires cutomers to accept the terms of service before
        /// being able to pay. If set to <c>none</c>, customers won't be shown a checkbox to accept
        /// the terms of service.
        /// One of: <c>none</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("terms_of_service")]
        public string TermsOfService { get; set; }
    }
}
