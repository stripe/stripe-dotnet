// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerSessionComponentsBuyButton : StripeEntity<CustomerSessionComponentsBuyButton>
    {
        /// <summary>
        /// Whether the buy button is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
