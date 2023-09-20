// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Controls whether Stripe will automatically compute tax on the resulting invoices or
        /// subscriptions as well as the quote itself.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        public QuoteAutomaticTaxLiabilityOptions Liability { get; set; }
    }
}
