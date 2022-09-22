// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionConsentCollection : StripeEntity<SessionConsentCollection>
    {
        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications. The Checkout Session will determine whether to display an option to opt
        /// into promotional communication from the merchant depending on the customer's locale.
        /// Only available to US merchants.
        /// One of: <c>auto</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("promotions")]
        public string Promotions { get; set; }

        /// <summary>
        /// If set to <c>required</c>, it requires customers to accept the terms of service before
        /// being able to pay.
        /// One of: <c>none</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("terms_of_service")]
        public string TermsOfService { get; set; }
    }
}
