// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponCustom : StripeEntity<CouponCustom>
    {
        /// <summary>
        /// The configuration supplied to the extension.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        [JsonProperty("extension")]
        [STJS.JsonPropertyName("extension")]
        public CouponCustomExtension Extension { get; set; }
    }
}
