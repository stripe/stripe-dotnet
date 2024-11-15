// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PromotionCodeRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Promotion codes defined in each available currency option. Each key must be a
        /// three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a> and a <a href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency_options")]
#endif

        public Dictionary<string, PromotionCodeRestrictionsCurrencyOptionsOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// A Boolean indicating if the Promotion Code should only be redeemed for Customers without
        /// any successful payments or invoices.
        /// </summary>
        [JsonProperty("first_time_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_time_transaction")]
#endif

        public bool? FirstTimeTransaction { get; set; }

        /// <summary>
        /// Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase
        /// must be $100 or more to work).
        /// </summary>
        [JsonProperty("minimum_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_amount")]
#endif

        public long? MinimumAmount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code</a> for
        /// minimum_amount.
        /// </summary>
        [JsonProperty("minimum_amount_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_amount_currency")]
#endif

        public string MinimumAmountCurrency { get; set; }
    }
}
