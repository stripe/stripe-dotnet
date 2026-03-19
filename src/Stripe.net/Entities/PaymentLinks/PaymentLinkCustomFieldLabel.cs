// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkCustomFieldLabel : StripeEntity<PaymentLinkCustomFieldLabel>
    {
        /// <summary>
        /// Custom text for the label, displayed to the customer. Up to 50 characters.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public string Custom { get; set; }

        /// <summary>
        /// The type of the label.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
