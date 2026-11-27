// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionMarketingAttributionAdConversionOptions : INestedOptions
    {
        /// <summary>
        /// Whether the customer consented to sending conversion data to an advertising platform.
        /// </summary>
        [JsonProperty("consent_collected")]
        [STJS.JsonPropertyName("consent_collected")]
        public bool? ConsentCollected { get; set; }

        /// <summary>
        /// The URL of the web page where the customer converted.
        /// </summary>
        [JsonProperty("source_url")]
        [STJS.JsonPropertyName("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// The user agent of the browser where the customer converted.
        /// </summary>
        [JsonProperty("user_agent")]
        [STJS.JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
