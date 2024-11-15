// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PromotionCodeRestrictionsCurrencyOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonProperty("minimum_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_amount")]
#endif

        public long? MinimumAmount { get; set; }
    }
}
