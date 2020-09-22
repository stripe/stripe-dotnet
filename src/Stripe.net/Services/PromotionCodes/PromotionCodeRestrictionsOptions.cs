// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PromotionCodeRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// A Boolean indicating if the Promotion Code should only be redeemed for Customers without
        /// any successful payments or invoices.
        /// </summary>
        [JsonProperty("first_time_transaction")]
        public bool? FirstTimeTransaction { get; set; }

        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonProperty("minimum_amount")]
        public long? MinimumAmount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code</a> for
        /// minimum_amount.
        /// </summary>
        [JsonProperty("minimum_amount_currency")]
        public string MinimumAmountCurrency { get; set; }
    }
}
