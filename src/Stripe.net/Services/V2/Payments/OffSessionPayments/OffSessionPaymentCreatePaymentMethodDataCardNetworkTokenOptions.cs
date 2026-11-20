// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreatePaymentMethodDataCardNetworkTokenOptions : INestedOptions
    {
        /// <summary>
        /// Two-digit number representing the network token's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the network token's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public string ExpYear { get; set; }

        /// <summary>
        /// The full network token number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// The tokenization method used to generate the network token.
        /// One of: <c>apple_pay</c>, <c>google_pay_dpan</c>, or <c>google_pay_ecommerce_token</c>.
        /// </summary>
        [JsonProperty("tokenization_method")]
        [STJS.JsonPropertyName("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
