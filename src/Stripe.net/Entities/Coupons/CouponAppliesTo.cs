namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CouponAppliesTo : StripeEntity<CouponAppliesTo>
    {
        /// <summary>
        /// A list of product IDs this coupon applies to.
        /// </summary>
        [JsonProperty("products")]
        public List<string> Products { get; set; }
    }
}
