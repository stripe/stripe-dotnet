// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionLineItemDetailProductDetailsCustomAttribute : StripeEntity<RequestedSessionLineItemDetailProductDetailsCustomAttribute>
    {
        /// <summary>
        /// The display name of the custom attribute.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The value of the custom attribute.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
