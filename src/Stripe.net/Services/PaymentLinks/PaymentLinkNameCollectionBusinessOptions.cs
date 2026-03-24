// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkNameCollectionBusinessOptions : INestedOptions
    {
        /// <summary>
        /// Enable business name collection on the payment link. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to provide their business name before checking out.
        /// Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
        [STJS.JsonPropertyName("optional")]
        public bool? Optional { get; set; }
    }
}
