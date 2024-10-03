// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountExternalAccountCardTokenOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; } = "card";

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
