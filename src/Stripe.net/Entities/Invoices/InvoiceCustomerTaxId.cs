namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceCustomerTaxId : StripeEntity<InvoiceCustomerTaxId>
    {
        /// <summary>
        /// Type of the tax ID, one of <c>eu_vat</c>, <c>nz_gst</c>, <c>au_abn</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
