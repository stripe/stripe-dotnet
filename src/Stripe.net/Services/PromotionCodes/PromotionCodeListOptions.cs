// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PromotionCodeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Filter promotion codes by whether they are active.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return promotion codes that have this case-insensitive code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Only return promotion codes for this coupon.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Only return promotion codes that are restricted to this customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
