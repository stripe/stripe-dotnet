// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataSofortOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// One of: <c>AT</c>, <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>IT</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
