// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CouponAppliesToOptions : INestedOptions
    {
        /// <summary>
        /// An array of Product IDs that this Coupon will apply to.
        /// </summary>
        [JsonProperty("products")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("products")]
#endif

        public List<string> Products { get; set; }
    }
}
