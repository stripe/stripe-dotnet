// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditNotePreviewLinesLineTaxAmountOptions : INestedOptions
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the tax.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The id of the tax rate for this tax amount. The tax rate must have been automatically
        /// created by Stripe.
        /// </summary>
        [JsonProperty("tax_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rate")]
#endif
        public string TaxRate { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxable_amount")]
#endif
        public long? TaxableAmount { get; set; }
    }
}
