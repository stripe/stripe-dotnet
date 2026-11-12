// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CouponCustomOptions : INestedOptions
    {
        /// <summary>
        /// The configuration values of the extension. The keys and values are specific to the
        /// extension implementation. May be omitted for extensions that have no configuration
        /// schema, in which case an empty configuration is used.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// The extension used to calculate the coupon.
        /// </summary>
        [JsonProperty("extension")]
        [STJS.JsonPropertyName("extension")]
        public CouponCustomExtensionOptions Extension { get; set; }
    }
}
