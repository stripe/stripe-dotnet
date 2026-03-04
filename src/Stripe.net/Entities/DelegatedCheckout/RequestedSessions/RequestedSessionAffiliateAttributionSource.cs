// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionAffiliateAttributionSource : StripeEntity<RequestedSessionAffiliateAttributionSource>
    {
        /// <summary>
        /// The platform of the attribution source.
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public string Platform { get; set; }

        /// <summary>
        /// The type of the attribution source.
        /// One of: <c>platform</c>, or <c>url</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The URL of the attribution source.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
