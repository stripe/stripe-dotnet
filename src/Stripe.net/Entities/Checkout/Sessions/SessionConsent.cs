// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionConsent : StripeEntity<SessionConsent>
    {
        /// <summary>
        /// If <c>opt_in</c>, the customer consents to receiving promotional communications from the
        /// merchant about this Checkout Session.
        /// One of: <c>opt_in</c>, or <c>opt_out</c>.
        /// </summary>
        [JsonProperty("promotions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotions")]
#endif

        public string Promotions { get; set; }

        /// <summary>
        /// If <c>accepted</c>, the customer in this Checkout Session has agreed to the merchant's
        /// terms of service.
        /// </summary>
        [JsonProperty("terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terms_of_service")]
#endif

        public string TermsOfService { get; set; }
    }
}
