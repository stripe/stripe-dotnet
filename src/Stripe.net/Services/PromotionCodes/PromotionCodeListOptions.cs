// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PromotionCodeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
