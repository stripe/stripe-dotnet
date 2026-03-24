// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenCvcUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The CVC value, in string form.
        /// </summary>
        [JsonProperty("cvc")]
        [STJS.JsonPropertyName("cvc")]
        public string Cvc { get; set; }
    }
}
