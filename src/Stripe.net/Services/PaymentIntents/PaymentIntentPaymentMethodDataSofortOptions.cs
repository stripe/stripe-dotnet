// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataSofortOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// One of: <c>AT</c>, <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>IT</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
