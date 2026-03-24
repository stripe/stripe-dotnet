// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CouponScriptOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The configuration values of the script. The keys and values are specific to the script
        /// implementation.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// The script implementation ID for this coupon.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
