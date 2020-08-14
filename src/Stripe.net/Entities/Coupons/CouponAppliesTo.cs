namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CouponAppliesTo : StripeEntity<CouponAppliesTo>
    {
        [JsonProperty("products")]
        public List<string> Products { get; set; }
    }
}
