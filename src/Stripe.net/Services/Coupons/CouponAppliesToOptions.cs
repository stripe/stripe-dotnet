// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CouponAppliesToOptions : INestedOptions
    {
        /// <summary>
        /// An array of Product IDs that this Coupon will apply to.
        /// </summary>
        [JsonProperty("products")]
        [STJS.JsonPropertyName("products")]
        public List<string> Products { get; set; }
    }
}
