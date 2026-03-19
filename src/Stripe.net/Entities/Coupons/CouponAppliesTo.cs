// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponAppliesTo : StripeEntity<CouponAppliesTo>
    {
        /// <summary>
        /// A list of product IDs this coupon applies to.
        /// </summary>
        [JsonProperty("products")]
        [STJS.JsonPropertyName("products")]
        public List<string> Products { get; set; }
    }
}
