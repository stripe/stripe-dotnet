// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Controls whether Stripe will automatically compute tax on this invoice.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
