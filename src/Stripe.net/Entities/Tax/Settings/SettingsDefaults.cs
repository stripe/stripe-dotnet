// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsDefaults : StripeEntity<SettingsDefaults>
    {
        /// <summary>
        /// Default <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> used to
        /// classify your products and prices.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
