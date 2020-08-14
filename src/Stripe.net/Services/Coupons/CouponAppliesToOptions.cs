namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CouponAppliesToOptions : INestedOptions
    {
        [JsonProperty("products")]
        public List<string> Products { get; set; }
    }
}
