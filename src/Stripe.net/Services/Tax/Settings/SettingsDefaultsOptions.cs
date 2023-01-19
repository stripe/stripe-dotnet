// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsDefaultsOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
