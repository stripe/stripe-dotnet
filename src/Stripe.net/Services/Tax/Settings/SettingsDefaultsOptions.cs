// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }
    }
}
