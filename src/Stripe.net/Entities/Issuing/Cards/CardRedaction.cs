// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardRedaction : StripeEntity<CardRedaction>
    {
        /// <summary>
        /// Indicates whether this object and its related objects have been redacted or not.
        /// One of: <c>processing</c>, <c>redacted</c>, or <c>validated</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
