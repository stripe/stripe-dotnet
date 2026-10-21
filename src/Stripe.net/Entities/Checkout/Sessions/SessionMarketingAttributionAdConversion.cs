// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionMarketingAttributionAdConversion : StripeEntity<SessionMarketingAttributionAdConversion>
    {
        /// <summary>
        /// Whether the customer consented to sending conversion data to an advertising platform.
        /// </summary>
        [JsonProperty("consent_collected")]
        [STJS.JsonPropertyName("consent_collected")]
        public bool ConsentCollected { get; set; }
    }
}
