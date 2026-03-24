// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SettingsDefaults : StripeEntity<SettingsDefaults>
    {
        /// <summary>
        /// The tax calculation provider this account uses. Defaults to <c>stripe</c> when not using
        /// a <a href="https://stripe.com/tax/third-party-apps">third-party provider</a>.
        /// One of: <c>anrok</c>, <c>avalara</c>, <c>sphere</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Default <a
        /// href="https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#tax-behavior">tax
        /// behavior</a> used to specify whether the price is considered inclusive of taxes or
        /// exclusive of taxes. If the item's price has a tax behavior set, it will take precedence
        /// over the default tax behavior.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>inferred_by_currency</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Default <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> used to
        /// classify your products and prices.
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }
    }
}
