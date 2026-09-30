// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationPaymentMethodDataCardOptions : INestedOptions
    {
        [JsonProperty("cvc")]
        [STJS.JsonPropertyName("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonProperty("token")]
        [STJS.JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
