// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsDefaults : StripeEntity<SettingsDefaults>
    {
        /// <summary>
        /// Default <a
        /// href="https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#tax-behavior">tax
        /// behavior</a> used to specify whether the price is considered inclusive of taxes or
        /// exclusive of taxes. If the item's price has a tax behavior set, it will take precedence
        /// over the default tax behavior.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>inferred_by_currency</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Default <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> used to
        /// classify your products and prices.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
