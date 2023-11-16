// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteLineTaxAmountOptions : INestedOptions
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the tax.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The id of the tax rate for this tax amount. The tax rate must have been automatically
        /// created by Stripe.
        /// </summary>
        [JsonProperty("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
        public long? TaxableAmount { get; set; }
    }
}
