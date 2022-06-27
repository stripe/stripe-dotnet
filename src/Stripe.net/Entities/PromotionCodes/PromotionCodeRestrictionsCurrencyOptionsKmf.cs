// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PromotionCodeRestrictionsCurrencyOptionsKmf : StripeEntity<PromotionCodeRestrictionsCurrencyOptionsKmf>
    {
        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonProperty("minimum_amount")]
        public long MinimumAmount { get; set; }
    }
}
