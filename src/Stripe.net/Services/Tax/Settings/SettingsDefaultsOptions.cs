// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsDefaultsOptions : INestedOptions
    {
        /// <summary>
        /// Specifies the default <a
        /// href="https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#tax-behavior">tax
        /// behavior</a> to be used when the item's price has unspecified tax behavior. One of
        /// inclusive, exclusive, or inferred_by_currency. Once specified, it cannot be changed back
        /// to null.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>inferred_by_currency</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
