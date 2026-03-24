// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionNameCollectionBusinessOptions : INestedOptions
    {
        /// <summary>
        /// Enable business name collection on the Checkout Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to provide a business name before completing the
        /// Checkout Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
        [STJS.JsonPropertyName("optional")]
        public bool? Optional { get; set; }
    }
}
