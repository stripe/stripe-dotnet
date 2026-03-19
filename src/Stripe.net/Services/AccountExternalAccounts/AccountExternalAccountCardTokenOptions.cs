// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountExternalAccountCardTokenOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; } = "card";

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("token")]
        [STJS.JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
