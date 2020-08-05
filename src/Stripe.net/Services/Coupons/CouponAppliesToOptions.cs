namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CouponAppliesToOptions : INestedOptions
    {
        /// <summary>
        /// An array of Product IDs that this Coupon will apply to.
        /// </summary>
        [JsonProperty("products")]
        public List<string> Products { get; set; }
    }
}
