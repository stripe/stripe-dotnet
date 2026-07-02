// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerPaymentTokenCardWallet : StripeEntity<CustomerPaymentTokenCardWallet>
    {
        /// <summary>
        /// The type of the card wallet, one of <c>apple_pay</c> or <c>google_pay</c>.
        /// One of: <c>apple_pay</c>, or <c>google_pay</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
