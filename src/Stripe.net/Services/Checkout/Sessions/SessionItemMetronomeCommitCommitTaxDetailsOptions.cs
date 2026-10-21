// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemMetronomeCommitCommitTaxDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Stripe <a href="https://docs.stripe.com/tax/tax-codes">tax code</a> for this commit (for
        /// example, <c>txcd_10103000</c>). If the linked Stripe Product has a tax code, this value
        /// must match it.
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }
    }
}
