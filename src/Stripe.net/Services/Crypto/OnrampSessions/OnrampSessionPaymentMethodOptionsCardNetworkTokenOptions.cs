// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionPaymentMethodOptionsCardNetworkTokenOptions : INestedOptions
    {
        /// <summary>
        /// The cryptogram, also known as the "token authentication verification value" (TAVV). This
        /// value is base64-encoded and is retrieved from your Token Service Provider. Provide a
        /// fresh cryptogram for each new authorization attempt.
        /// </summary>
        [JsonProperty("cryptogram")]
        [STJS.JsonPropertyName("cryptogram")]
        public string Cryptogram { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI) returned by your Token Service Provider along
        /// with the cryptogram for Visa network tokens. When used alongside 3-D Secure, provide the
        /// ECI returned by your Token Service Provider. Required for Visa network tokens. Omit for
        /// Mastercard network tokens.
        /// One of: <c>05</c>, <c>06</c>, or <c>07</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("electronic_commerce_indicator")]
        [STJS.JsonPropertyName("electronic_commerce_indicator")]
        public string ElectronicCommerceIndicator { get; set; }
    }
}
